using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Sources:
 * https://docs.microsoft.com/en-us/dotnet/csharp/how-to/parse-strings-using-split
 * https://docs.microsoft.com/en-us/dotnet/desktop/winforms/forms/how-to-add?view=netdesktop-5.0
 * 
 */

namespace Project_8b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] inputFile = System.IO.File.ReadAllLines("peoples.txt");
            string[] entryPlaceHolder = new string[3];
            int size = inputFile.Length;
            PersonEntry[] individuals = new PersonEntry[size];
            for(int i = 0; i < size; i++)
            {
                entryPlaceHolder = inputFile[i].Split();
                individuals[i] = new PersonEntry(entryPlaceHolder[0], entryPlaceHolder[1], entryPlaceHolder[2]);
                peopleOutput.Items.Add(entryPlaceHolder[0]);
            } 
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void show_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Activate();
            Form2.ActiveForm.Visible = true;
        }
    }


    public class PersonEntry
    {
        private string name, email, phoneNum;

       public PersonEntry(string n, string e, string p)
        {
            name = n;
            email = e;
            phoneNum = p;
        }

        public string getName()
        {
            return name;
        }

        public string getEmail()
        {
            return email;
        }

        public string getPhoneNum()
        {
            return phoneNum;
        }
    }
}
