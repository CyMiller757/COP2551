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

/*Sources:
 * https://www.guru99.com/c-sharp-stream.html
 * 
 * 
 * 
 * 
 */

namespace Rand_List_thingy
{
   
    public partial class Form1 : Form
    {

        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void runButt_Click(object sender, EventArgs e)
        {
           try
           {
                int numsToGenerate;
                int placeHolder;
                string fileName = "randNumHolder.txt";
                numsToGenerate = int.Parse(inputThing.Text);
                File.Delete(fileName);
                File.Create(fileName).Close();
                using (StreamWriter data = File.AppendText(fileName))
                {
                    for (int i = 0; i < numsToGenerate; i++)
                    {
                     placeHolder = rand.Next(0, 100);
                     data.WriteLine(placeHolder);

                    }
                }

                string[] arrayHolder = File.ReadAllLines(fileName);
                string outer = "";
                for(int i = 0; i < arrayHolder.Length; i++)
                {
                    outer += arrayHolder[i] + "\n";
                }
                outputData.Text = outer;
                outputData.Visible = true;
                
           }
           catch
           {
            MessageBox.Show("Please enter correct input!");
           }
        }
    }
}
