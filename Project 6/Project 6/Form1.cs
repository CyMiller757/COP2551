using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Sources used:
 * https://stackoverflow.com/questions/23750228/use-an-array-to-assign-values-to-list-box
 * https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-read-from-a-text-file
 * 
 */


namespace Project_6
{
    public partial class WorldSeries : Form
    {
        //establish global variables
        string[] teams = System.IO.File.ReadAllLines("Teams.txt");
        string[] champs = System.IO.File.ReadAllLines("WorldSeries.txt");
        public WorldSeries()
        {
            //add the Teams.txt info into the list box
            InitializeComponent();
            teamsBox.Items.AddRange(teams);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //check how many times the selected team has won the world series
            int counter = 0;
            if(teamsBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a team!");
            }
            else
            {
                foreach (string a in champs)
                {
                    if (teamsBox.SelectedItem.ToString() == a)
                    {
                        counter++;
                    }
                    testText.Text = "The " + teamsBox.SelectedItem + " have won " + counter.ToString() + " time(s)!";
                }

            }
        }

        //Riddle me this Batman, what could the following code possibly be used for? C'mon now Batman... THINK!
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
