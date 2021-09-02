using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double inputVal = double.Parse(inputBox.Text);
                string inputUnit = inputUnits.Text;
                string outputUnit = outputUnits.Text;
                double baseline = 0, outputVal = 0;
                if (inputUnit == outputUnit)
                {
                    outputVal = inputVal;
                }
                else
                {
                    switch (inputUnit) //help from https://www.geeksforgeeks.org/c-sharp-how-to-use-strings-in-switch-statement/
                    {
                        case "Inches":
                            baseline = inputVal;
                            break;
                        case "Feet":
                            baseline = inputVal * 12;
                            break;
                        case "Yards":
                            baseline = inputVal * 36;
                            break;
                    }
                    switch (outputUnit)
                    {
                        case "Inches":
                            outputVal = baseline;
                            break;
                        case "Feet":
                            outputVal = baseline / 12;
                            break;
                        case "Yards":
                            outputVal = baseline / 36;
                            break;

                    }
                }
                outBox.Text = (outputVal + " " + outputUnit);
            }
            catch
            {
                MessageBox.Show("Invalid input", "Input Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

    }
}
