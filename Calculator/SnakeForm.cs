using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class SnakeForm : Form
    {
        bool spawning = false;
        bool redrawSnake = false;

        Graphics g;
        Point origin;
        Point start;
        Pen snakePen;

        List<Rectangle> snakeParts = new List<Rectangle>();

        Direction currentDirection;

        public enum Direction
        {
            up,
            down,
            left,
            right
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // CODE TO ENABLE DOUBLE BUFFERING       
                return handleParam;
            }
        }

        public SnakeForm()
        {
            InitializeComponent();
        }

        private void SnakeForm_Load(object sender, EventArgs e)
        {
            drawTimer.Start();
            spawning = true;
            initPoints();
        }

        private void initPoints()
        {
            origin = new Point(outputPanel.Width / 2, outputPanel.Height / 2);
            start = new Point(10, 10);
            snakePen = new Pen(Color.Black, 2);
            g = outputPanel.CreateGraphics();
        }

        private void outputPanel_Paint(object sender, PaintEventArgs e)
        {
            if (spawning)
            {
                spawning = false;
                Rectangle newSnake = new Rectangle(start, new Size(10, 10));
                snakeParts.Add(newSnake);
                newSnake.Location = new Point(newSnake.Location.X, newSnake.Location.Y + 11);
                snakeParts.Add(newSnake);
                currentDirection = Direction.down;
            }

            snakeDraw();
            drawGrid(); // draw on the grid

        }

        private void snakeDraw()
        {
            if (redrawSnake)
            {
                Debug.WriteLine("Redrawing snake");
                redrawSnake = false;
                List<Rectangle> newSnakes = new List<Rectangle>();
                foreach (Rectangle part in snakeParts)
                {
                    Point newPoint = new Point();
                    switch (currentDirection)
                    {
                        case Direction.up:
                            newPoint = new Point(part.Location.X,part.Location.Y-10);
                            Debug.WriteLine(newPoint);
                            break;
                        case Direction.down:
                            newPoint = new Point(part.Location.X,part.Location.Y+10);
                            Debug.WriteLine(newPoint);
                            break;
                        case Direction.left:
                            newPoint = new Point(part.Location.X-10,part.Location.Y);
                            Debug.WriteLine(newPoint);
                            break;
                        case Direction.right:
                            newPoint = new Point(part.Location.X+10,part.Location.Y);
                            Debug.WriteLine(newPoint);
                            break;
                        default:
                            break;
                    }
                    Rectangle newSnakePart =new Rectangle(newPoint, new Size(10, 10));
                    newSnakes.Add(newSnakePart);
                    g.DrawRectangle(snakePen, newSnakePart);
                }
                snakeParts = newSnakes;
            }

        }

        private void drawGrid()
        {
            Pen gridPen = new Pen(Color.Gray, 1);
            int width = outputPanel.Width;
            int height = outputPanel.Height;
            int sectors = 10;
            int widthGap = width / 10;
            int heightGap = height / 10;

            int currentX = widthGap;
            int currentY = heightGap;

            for (int i = 0; i < sectors; i++)
            {
                Point top = new Point(currentX, 0);
                Point bottom = new Point(currentX, height);
                Point left = new Point(0, currentY);
                Point right = new Point(width, currentY);
                g.DrawLine(gridPen, top, bottom);
                g.DrawLine(gridPen, left, right);
                currentX += widthGap;
                currentY += heightGap;
            }
        }

        private void drawTimer_Tick(object sender, EventArgs e)
        {
            Debug.WriteLine("Tick");
            redrawSnake = true;
            outputPanel.Refresh();
        }

        private void SnakeForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                currentDirection = Direction.down;
            }
            if (e.KeyCode == Keys.Up)
            {
                currentDirection = Direction.up;
            }
            if (e.KeyCode == Keys.Left)
            {
                currentDirection = Direction.left;
            }
            if (e.KeyCode == Keys.Right)
            {
                currentDirection = Direction.right;
            }

        }
    }
}
