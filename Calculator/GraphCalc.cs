using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
    public partial class GraphCalc : Form
    {
        private float mVal;
        private float cVal;
        private float a;
        private float b;
        private float c;
        private Point origin;
        private Point topMiddle;  //ALL POINTS ON GRAPH
        private Point bottomMiddle;
        private Point leftMiddle;
        private Point rightMiddle;
        private Graphics graphics;
        private Pen pen;
        private Pen LinePen;
        private bool DrawMX = false;
        private bool DrawABC = false;

        public GraphCalc()
        {
            InitializeComponent();
        }
        private void GraphCalc_Load(object sender, EventArgs e)
        {
            graphics = graphBox.CreateGraphics();
            pen = new Pen(Color.Black, 1);
            LinePen = new Pen(Color.Blue, float.Parse("1.2"));
            InitPoints();
            Debug.WriteLine(origin);
            Debug.WriteLine(topMiddle); // init points and pens and output to debug
            Debug.WriteLine(bottomMiddle);
            Debug.WriteLine(leftMiddle);
            Debug.WriteLine(rightMiddle);
        }

        private void InitPoints()
        {
            origin = new Point(graphBox.Width / 2, graphBox.Height / 2);
            topMiddle = new Point(graphBox.Width / 2, 0);
            bottomMiddle = new Point(graphBox.Width / 2, graphBox.Height); // get points on graph for axis
            leftMiddle = new Point(0, graphBox.Height / 2);
            rightMiddle = new Point(graphBox.Width, graphBox.Height / 2);
        }

        private void basicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.basicCalc.Show();
            Hide();
        }

        private void convertionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.ConvertionCalc.Show(); // menu strip selection config
            Hide();
        }

        private void GraphCalc_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.basicCalc.Show();
        }

        private void MValue_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(mValue.Text, out mVal))
            {
                mValue.BackColor = Color.LightGreen; // when an M value is inputted provide feedback as to validity 
            }
            else
            {
                mValue.BackColor = Color.FromKnownColor(KnownColor.Window);
            }
        }

        private void CValue_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(cValue.Text, out cVal))
            {
                cValue.BackColor = Color.FromKnownColor(KnownColor.LightGreen); // when an C value is inputted provide feedback as to validity 
            }
            else
            {
                cValue.BackColor = Color.FromKnownColor(KnownColor.Window);
            }
        }

        private void GraphBox_Paint(object sender, PaintEventArgs e)
        {
            // DrawCurrentGraph // depending on graph type generate and draw on all points on graph
            graphics.DrawLine(pen, leftMiddle, rightMiddle);
            graphics.DrawLine(pen, topMiddle, bottomMiddle);
            if (DrawMX)
            {
                DrawMX = false; // trigger
                Point[] points = YMXGen(mVal, cVal); // gen using normal 
 
                graphics.DrawCurve(LinePen, points);
            }
            else if (DrawABC)
            {
                DrawABC = false;
                Point[] points = ABCGen(a, b, c); // gen using quadratic

                graphics.DrawCurve(LinePen, points);
            }
        }

        private Point[] ABCGen(float a, float b, float c)
        {
            if(!removeCMultOpt.Checked) c *= 10; // c zoom for better graphs
            List<Point> points = new List<Point>(); // create points list 
            int width = graphBox.Width / 2;// store width 
            List<int> xVals = new List<int>(); // make a new list of xVals
            for (int pnt = 0; pnt < graphBox.Width; pnt++)
            {
                xVals.Add(pnt - (width)); // generate all x values for graph 
            }
            foreach (int point in xVals) // get the relative y value for each x value 
            {
                points.Add(new Point(origin.X + point, origin.Y -
                    (Convert.ToInt32(Math.Pow(a * point, 2)
                    + (b * point)
                    + c)))); // work out points on a quadratic curve
            }
            return points.ToArray(); // change to an array for DrawCurve function
        }

        private Point[] YMXGen(float M, float C)
        {
            //LOGIC same as above but different math
            if(!removeCMultOpt.Checked) C *= 10;
            List<Point> points = new List<Point>();
            int width = graphBox.Width / 2;
            List<int> xVals = new List<int>();
            for (int pnt = 0; pnt < graphBox.Width; pnt++)
            {
                xVals.Add(pnt - (width)); // generate all x values for graph 
            }
            foreach (int point in xVals)
            {
                points.Add(new Point(origin.X + point, origin.Y - Convert.ToInt32((M * point) + C)));
            }
            return points.ToArray();
        }

        private void DrawBtn_Click(object sender, EventArgs e)
        {
            if (normalGraphOpt.Checked) // check which graph is being drawn and check if input is valid using textbox colour
            {
                if (mValue.BackColor != Color.LightGreen || cValue.BackColor != Color.LightGreen)
                {
                    return; // invalid floats
                }
                DrawMX = true;
                graphBox.Refresh();// refresh (draw) graph
            }
            else // quadratic becuase not normal 
            {
                if (AVal.BackColor != Color.LightGreen || BVal.BackColor != Color.LightGreen || _CVal.BackColor != Color.LightGreen)
                {
                    return; // invalid floats
                }
                DrawABC = true;
                graphBox.Refresh(); // refresh (draw) graph
            }
        }

        private void AX2BXCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quadraticGraphOpt.Checked = true;
            normalGraphOpt.Checked = false; // handling graph selection same as below
            groupBox2.Show();
        }

        private void YMXCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            normalGraphOpt.Checked = true;
            quadraticGraphOpt.Checked = false;
            groupBox2.Hide();
        }

        private void AVal_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(AVal.Text, out a))
            {
                AVal.BackColor = Color.LightGreen;
            } // same as above, validating input for graph and storing in class wide variable
            else
            {
                AVal.BackColor = Color.FromKnownColor(KnownColor.Window);
            }
        }

        private void BVal_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(BVal.Text, out b))
            {
                BVal.BackColor = Color.LightGreen;
            }
            else
            {
                BVal.BackColor = Color.FromKnownColor(KnownColor.Window);
            }
        }

        private void _CVal_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(_CVal.Text, out c))
            {
                _CVal.BackColor = Color.LightGreen;
            }
            else
            {
                _CVal.BackColor = Color.FromKnownColor(KnownColor.Window);
            }
        }

        private void RemoveCMultOpt_Click(object sender, EventArgs e)
        {
            removeCMultOpt.Checked = !removeCMultOpt.Checked; // toggle checked
            DrawBtn_Click(sender, EventArgs.Empty); //simul;ate button for redraw
        }
    }
}
