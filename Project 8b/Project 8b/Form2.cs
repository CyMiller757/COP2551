using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_8b
{
    public partial class Form2 : Form
    {
        public Form2(string output)
        {
            //show it
            InitializeComponent();
            showData.Text = output;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        //close it
        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
