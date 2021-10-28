using System;
using System.IO;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        //Always Be Closing
        private void cancelButt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enterPersonButt_Click(object sender, EventArgs e)
        {
            //take input values and add to text
            using (StreamWriter sw = File.AppendText("peoples.txt"))
            {
                sw.WriteLine(nameBox.Text + " " + emailBox.Text + " " + phoneBox.Text);
            }
            
            Form1 done = new Form1();
            done.initSystem();
            this.Close();

        }
    }
}
