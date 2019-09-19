using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainForm : Form
    {
        private string currentMathString = ""; // for storing the current type of math
        public float numBuff = 0; // for storing the last number
        public List<KeyValuePair<float, CalcOption>> Ops = new List<KeyValuePair<float, CalcOption>>(); 
        // storing all operations
        private bool clearOnType = false;  // if the display needs to be cleared on typing flag
        private bool decimalPresent; // if a decimal p[oint is present in the 
        float displayedNumber; // for storing the current number on display as float for sin cos and tan functions 
        float prevAnswer; //store the previous answer to the calculation
        public enum CalcOption
        {
            Add = 1,
            Subtract = 2,
            Multiplied = 3, // to store the calculation as a new type
            Divided = 4,
            Power = 5
        }

        public MainForm()
        {
            InitializeComponent();
        }

        public void AddChar(char toAdd)
        {
            if (clearOnType)
            {
                outputBox.ResetText(); // clearing display if the flag is true and resetting
                clearOnType = false;
            }
            outputBox.Text += toAdd.ToString(); // add char to screen
        }

        public void AddOp(CalcOption calc, float number)
        {
            outputBox.ResetText(); // adding an operation to the list, takes val and a calculation type and adds it to list
            Ops.Add(new KeyValuePair<float, CalcOption>(number, calc)); // addding as a new pair
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddChar('1'); // adding characters to display
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddChar('2');
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddChar('3');
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddChar('4');
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddChar('5');
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddChar('6');
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddChar('7');
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddChar('8');
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddChar('9');
        }

        private void button0_Click(object sender, EventArgs e)
        {
            AddChar('0');
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            if (outputBox.Text == "" || outputBox.Text == ".") // check for empty input
            {
                return;
            }

            AddOp(CalcOption.Add, float.Parse(outputBox.Text)); // adding the different options, passing display as a float
        }

        private void divideBtn_Click(object sender, EventArgs e)
        {
            if (outputBox.Text == "" || outputBox.Text == ".")// check for empty input
            {
                return;
            }

            AddOp(CalcOption.Divided, float.Parse(outputBox.Text));
        }

        private void multBtn_Click(object sender, EventArgs e)
        {
            if (outputBox.Text == "" || outputBox.Text == ".")// check for empty input
            {
                return;
            }

            AddOp(CalcOption.Multiplied, float.Parse(outputBox.Text));
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            if (outputBox.Text == "" || outputBox.Text == ".")// check for empty input
            {
                return;
            }

            AddOp(CalcOption.Subtract, float.Parse(outputBox.Text));
        }

        private void powerBtn_Click(object sender, EventArgs e)
        {
            if (outputBox.Text == "" || outputBox.Text == ".")// check for empty input
            {
                return;
            }

            AddOp(CalcOption.Power, float.Parse(outputBox.Text)); 
        }

        private void DecimalBtn_Click(object sender, EventArgs e)
        {
            if (decimalPresent) // if a decimal already exists in the display, remove and replace
            {
                outputBox.Text = outputBox.Text.Replace(".", "");
                AddChar('.');
            }
            else
            {
                decimalPresent = true; // otherwise set flag to true and add the decimal
                AddChar('.');

            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            outputBox.ResetText(); // clear the display but leave ops list populated
        }

        private void evalBtn_Click(object sender, EventArgs e)
        {
            if (outputBox.Text == "" || outputBox.Text == ".") // check for empty screen on equals
            {
                return;
            }

            numBuff = float.Parse(outputBox.Text); // pass display into number buffer for last number
            GenerateMathString(); //  generate amath string for debugging
            doMath(); // do the math specified in ops list
        }

        private void GenerateMathString()
        {
            currentMathString = "";
            foreach (KeyValuePair<float, CalcOption> item in Ops)
            {
                currentMathString += item.Key.ToString() + item.Value.ToString();
            }
            currentMathString += numBuff + Environment.NewLine;
#if DEBUG
            MessageBox.Show("DEBUG: Math string : " + currentMathString); // if in debug, show math string
#endif
        }

        private void doMath()
        {
            if (Ops.Count == 0)
            {
#if DEBUG
                MessageBox.Show("DEBUG: Empty Math.. Aborting"); // empty math
#endif
                return;
            }
            float result = Ops[0].Key; // read in first number from list
            for (int i = 0; i < Ops.Count; i++)
            {
                KeyValuePair<float, CalcOption> Operation; // make a keyvaluepair for the operation
                float nextNum; // and a float for the next number
                try
                {
                    Operation = Ops[i]; // read the current op into operation
                    nextNum = Ops[i + 1].Key; // and into next num
                }
                catch (ArgumentOutOfRangeException)
                {
                    Operation = Ops[i];
                    nextNum = numBuff; // or if its the last operation use numbuff
                }
                switch (Ops[i].Value)
                {
                    case CalcOption.Add:
                        result = result + nextNum;
                        break;
                    case CalcOption.Subtract:
                        result = result - nextNum;
                        break;
                    case CalcOption.Multiplied:
                        result = result * nextNum; // do the math and add result to grand total
                        break;
                    case CalcOption.Divided:
                        result = result / nextNum;
                        break;
                    case CalcOption.Power:
                        result = float.Parse(Math.Pow(result, nextNum).ToString());
                        break;
                    default:
                        break; // do nothing on empty math ( shouldn't happpen )
                }
            }
            prevAnswer = result;
            outputBox.Text = result.ToString(); // convert result back to string
            Ops = new List<KeyValuePair<float, CalcOption>>(); // reset calc list 
            return; // math finished
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Program.ConvertionCalc = new ConvForm();
            Program.GraphingCalc = new GraphCalc();// set up different forms to be accessed from Program class
            Program.basicCalc = this;
        }

        private void sinBtn_Click(object sender, EventArgs e)
        {
            if (float.TryParse(outputBox.Text, out displayedNumber))
            {
                outputBox.Text = Math.Sin(displayedNumber).ToString();
            }
        }

        private void cosBtn_Click(object sender, EventArgs e)
        {
            if (float.TryParse(outputBox.Text, out displayedNumber))
            {
                outputBox.Text = Math.Cos(displayedNumber).ToString(); // convert number currently on display to its trig form
            }
        }

        private void tanBtn_Click(object sender, EventArgs e)
        {
            if (float.TryParse(outputBox.Text, out displayedNumber))
            {
                outputBox.Text = Math.Tan(displayedNumber).ToString();
            }
        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            if (float.TryParse(outputBox.Text, out displayedNumber))
            {
                outputBox.Text = Math.Log(displayedNumber).ToString();
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            try
            {
                outputBox.Text = outputBox.Text.Remove(outputBox.Text.Length - 1);
            }
            catch (ArgumentOutOfRangeException) // remove last char unlesss it doesnt exist then dont do anything on that error
            {
                return;
            }
        }

        private void toggleNegativeBtn_Click(object sender, EventArgs e)
        {
            if (outputBox.Text.Contains("-")) // if a negative exists
            {
                outputBox.Text = outputBox.Text.Replace("-", "");   // replace it with nothing if it exists
            }
            else
            {
                outputBox.Text = "-" + outputBox.Text; // or add it if it doesn't
            }
        }

        private void basicToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void graphingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.GraphingCalc.Show(); // form switching logic 
            Hide();
        }

        private void convertionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.ConvertionCalc.Show();
            Hide();
        }

        private void tanhBtn_Click(object sender, EventArgs e)
        {
            if (float.TryParse(outputBox.Text, out displayedNumber))
            {
                outputBox.Text = Math.Tanh(displayedNumber).ToString(); // convert number currently on display to its trig form
            }
        }

        private void sinhBtn_Click(object sender, EventArgs e)
        {
            if (float.TryParse(outputBox.Text, out displayedNumber))
            {
                outputBox.Text = Math.Sinh(displayedNumber).ToString(); // convert number currently on display to its trig form
            }
        }

        private void coshBtn_Click(object sender, EventArgs e)
        {
            if (float.TryParse(outputBox.Text, out displayedNumber))
            {
                outputBox.Text = Math.Cosh(displayedNumber).ToString(); // convert number currently on display to its trig form
            }
        }

        private void ansBtn_Click(object sender, EventArgs e)
        {
#if DEBUG
            MessageBox.Show(prevAnswer.ToString());   
#endif
            outputBox.Text = prevAnswer.ToString();
        }

        private void outputBox_TextChanged(object sender, EventArgs e)
        {
            if (outputBox.Text == "11223344")
            {
                Form snakeForm = new SnakeForm();
                Hide();
                snakeForm.ShowDialog();
                Show();
            }

        }
    }
}