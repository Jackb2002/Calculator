using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Calculator
{
    public partial class ConvForm : Form
    {
        private string[] swapType = new string[2]; // swap type list var
        private bool firstUsed = false; // for handling conversion logic
        public ConvForm()
        {
            InitializeComponent();
        }

        private void basicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.basicCalc.Show();
            Hide();
        }

        private void graphingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.GraphingCalc.Show(); // menu strip selection
            Hide();
        }

        private void radioDen_CheckedChanged(object sender, EventArgs e)
        {
            if (!firstUsed) // chosing if to or from depending on if element one is used
            {
                swapType[0] = "den";
                firstUsed = true; // chaning the toggle as to fill the  list
            }
            else
            {
                swapType[1] = "den";
            }
            CheckConv(); //  check if it can be converted
        }

        private void radioHex_CheckedChanged(object sender, EventArgs e)
        {
            if (!firstUsed)
            {
                swapType[0] = "hex"; // same logic as above
                firstUsed = true;
            }
            else
            {
                swapType[1] = "hex";
            }
            CheckConv();
        }

        private void radioBin_CheckedChanged(object sender, EventArgs e)
        {
            if (!firstUsed)
            {
                swapType[0] = "bin"; // same logic as above
                firstUsed = true;
            }
            else
            {
                swapType[1] = "bin";
            }
            CheckConv();

        }

        private void CheckConv()
        {
            foreach (string item in swapType)
            {
                Debug.WriteLine(item); // write the swaptype to debug output 
            }
            if (swapType[0] != null && swapType[1] != null)
            {
                Conv(); // check if a complete swap is present and convert
            }
        }

        private void Conv()
        {
            string swapString = swapType[0] + swapType[1]; // join them as a string
            swapType = new string[2]; // empty the list
            firstUsed = false; // return to default
            Debug.WriteLine("SWAP STRING:"+swapString); // write the new string to debug 
            try
            {
                switch (swapString)
                {
                    case "denbin":
                        inputBox.Text = Convert.ToString(Convert.ToInt64(inputBox.Text, 10), 2); // convert den > bin
                        break;
                    case "denhex":
                        inputBox.Text = Convert.ToString(Convert.ToInt64(inputBox.Text, 10), 16);// convert den > hex
                        break;
                    case "binden":
                        inputBox.Text = Convert.ToString(Convert.ToInt64(inputBox.Text, 2), 10);// convert bin > den
                        break;
                    case "binhex":
                        inputBox.Text = Convert.ToString(Convert.ToInt64(inputBox.Text, 2), 16);// convert bin > hex
                        break;
                    case "hexden":
                        inputBox.Text = Convert.ToString(Convert.ToInt64(inputBox.Text, 16), 10);// convert hex > den
                        break;
                    case "hexbin":
                        inputBox.Text = Convert.ToString(Convert.ToInt64(inputBox.Text, 16), 2);// convert hex > bin
                        break;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                return; // empty input 
            }
            catch (FormatException)
            {
                string conv = string.Empty;
                conv += swapString.Substring(0, 3);
                conv += "-->";
                conv += swapString.Substring(3);
                MessageBox.Show("Incorrect Input Format For " + conv); // build an error message and out to debug output 
                return;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Overflow"); // if conbversion is bigger than 64 bit 
                return;
            }
            swapString = string.Empty;
        }

        private void ConvForm_Load(object sender, EventArgs e)
        {
            // nothing on load
        }

        private void ConvForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.basicCalc.Show();
        }

        private void InputBox_TextChanged(object sender, EventArgs e)
        {
            inputBox.Text = inputBox.Text.ToUpper(); // for hex, make capital for aesthetics
        }
    }
}
