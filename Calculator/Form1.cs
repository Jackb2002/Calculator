using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string currentMathString = "";
        public float numBuff = 0;
        public List<KeyValuePair<float, CalcOption>> Ops = new List<KeyValuePair<float, CalcOption>>();
        bool clearOnType = false;
        private List<string> opHistory = new List<string>();
        private bool decimalPresent;
        string stringBuff = ""; // stores last number
        public enum CalcOption
        {
            Add = 1,
            Subtract = 2,
            Multiplied = 3,
            Divided = 4,
            nil = 99
        }

        public Form1()
        {
            InitializeComponent();
        }

        public void AddChar(char toAdd)
        {
            if (clearOnType)
            {
                safeResetStrings();
            }
            outputBox.Text = outputBox.Text + toAdd.ToString();
        }

        private void safeResetStrings()
        {
            outputBox.TextChanged -= OutputBox_TextChanged; // to stop text changed event
            stringBuff = "";
            outputBox.ResetText();
            outputBox.TextChanged += OutputBox_TextChanged; // to restart event 
        }

        public void AddOp(CalcOption calc, float number)
        {
            stringBuff = "";
            if (outputBox.Text == "" || outputBox.Text == ".")
                return;
            Ops.Add(new KeyValuePair<float, CalcOption>(number, calc));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddChar('1');
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

        private void evalBtn_Click(object sender, EventArgs e)
        {
            if (outputBox.Text == "" || outputBox.Text == ".")
                return;
            numBuff = float.Parse(stringBuff);
            GenerateMathString();
            doMath();
        }

        private void checkBracketsPresence()
        {
        }

        private void GenerateMathString()
        {
            currentMathString = "";
            foreach (var item in Ops)
            {
                currentMathString += item.Key.ToString() + item.Value.ToString();
            }
            currentMathString += numBuff + Environment.NewLine;
#if DEBUG
            MessageBox.Show("DEBUG: Math string : " + currentMathString);
#endif
            opHistory.Add(currentMathString);
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            if (outputBox.Text == "" || outputBox.Text == ".")
                return;
            AddChar('+');
            AddOp(CalcOption.Add, float.Parse(stringBuff));
        }

        private void divideBtn_Click(object sender, EventArgs e)
        {
            if (outputBox.Text == "" || outputBox.Text == ".")
                return;
            AddChar('÷');
            AddOp(CalcOption.Divided, float.Parse(stringBuff));
        }

        private void multBtn_Click(object sender, EventArgs e)
        {
            if (outputBox.Text == "" || outputBox.Text == ".")
                return;
            AddChar('x');
            AddOp(CalcOption.Multiplied, float.Parse(stringBuff));
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            if (outputBox.Text == "" || outputBox.Text == ".")
                return;
            AddChar('-');
            AddOp(CalcOption.Subtract, float.Parse(stringBuff));
        }

        private void doMath()
        {
            if (Ops.Count == 0)
            {
#if DEBUG
                MessageBox.Show("DEBUG: Empty Math.. Aborting");
#endif
                return;
            }
            float result = Ops[0].Key; // first number
            for (int i = 0; i < Ops.Count; i++)
            {
                KeyValuePair<float, CalcOption> Operation;
                float nextNum;
                try
                {
                    Operation = Ops[i];
                    nextNum = Ops[i + 1].Key;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Operation = Ops[i];
                    nextNum = numBuff;
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
                        result = result * nextNum;
                        break;
                    case CalcOption.Divided:
                        result = result / nextNum;
                        break;
                    default:
                        break;
                }
            }
            Ops = new List<KeyValuePair<float, CalcOption>>(); // reset list
            outputBox.Text = result.ToString();
            clearOnType = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DecimalBtn_Click(object sender, EventArgs e)
        {
            if (decimalPresent)
            {
                outputBox.Text = outputBox.Text.Replace(".", "");
                AddChar('.');
            }
            else
            {
                decimalPresent = true;
                AddChar('.');

            }
        }

        private void OpenBracketBtn_Click(object sender, EventArgs e)
        {
            outputBox.Text += '(';
        }

        private void CloseBracketBtn_Click(object sender, EventArgs e)
        {
            outputBox.Text += ')';
        }

        private void OutputBox_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show(outputBox.Text);
            char lastChar = outputBox.Text[outputBox.Text.Length - 1];
            int number = 0;
            if (lastChar.ToString() == ".")
            {
                stringBuff += ".";
            }
            else if (int.TryParse(lastChar.ToString(), out number))
            {
                stringBuff += number;
            }
        }
    }
}
