using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double area = double.Parse(sqrInput.Text);
                double costPerGallon = double.Parse(perGallonCost.Text);
                double paintNeeded = area / 115;
                double labor = paintNeeded * 8;
                decimal paintCost = (decimal) paintNeeded * (decimal) costPerGallon;
                paintCost = Math.Round(paintCost, 2);
                decimal laborCost = (decimal) labor * 20;
                laborCost = Math.Round(laborCost, 2);
                decimal total = laborCost + paintCost;
                string output = "Gallons of paint needed: " + paintNeeded + "\nHours of labor: " + labor + "\nCost of paint: $" + paintCost + "\nCost of Labor: $" + laborCost + "\nTotal: $" + total;
                MessageBox.Show(output);
            }
            catch
            {
                MessageBox.Show("Invalid input", "Input Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
