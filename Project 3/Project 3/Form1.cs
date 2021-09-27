using System;
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
            //thing breaks if I delete this
        }


        //tried changing name of button1, but that breaks it too
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //get units and value
                double inputVal = double.Parse(inputBox.Text);
                string inputUnit = inputUnits.Text;
                string outputUnit = outputUnits.Text;
                double baseline = 0, outputVal = 0;

                //if they are the same, just output the value with no calculation
                if (inputUnit == outputUnit)
                {
                    outputVal = inputVal;
                }
                else
                {
                    //get input units and conver to baseline (basically inches)
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

                    //get output unit and convert baseline to that
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

                //output the value
                outBox.Text = (outputVal + " " + outputUnit);
            }
            catch
            {

                //if bad input, yell at user
                MessageBox.Show("Invalid input", "Input Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        //close
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
