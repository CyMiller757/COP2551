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
        public static string[] inputFile;
        public string[] entryPlaceHolder;
        public static int size;
        public static PersonEntry [] individuals;

        public void initSystem()
        {
            inputFile = System.IO.File.ReadAllLines("peoples.txt");
            entryPlaceHolder = new string[3];
            size = inputFile.Length;
            individuals = new PersonEntry[size];
            for (int i = 0; i < size; i++)
            {
                entryPlaceHolder = inputFile[i].Split();
                individuals[i] = new PersonEntry(entryPlaceHolder[0], entryPlaceHolder[1], entryPlaceHolder[2]);
                peopleOutput.Items.Add(entryPlaceHolder[0]);
            }
        }
        public Form1()
        {
           
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initSystem();
            
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void show_Click(object sender, EventArgs e)
        {
            int location = peopleOutput.SelectedIndex; ;
            string thing;
            if (location == -1)
            {
                MessageBox.Show("Please Select the Contact You wish to View");
            }
            else
            {
                thing = individuals[location].getAll();
                Form2 outputForm = new Form2(thing);
                outputForm.Show();
            }
            
        }

        private void addPerson_Click(object sender, EventArgs e)
        {
            Form3 enterPersonForm = new Form3();
            enterPersonForm.Show();

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

        public string getAll()
        {
            return "Name: " + name + "\nEmail: " + email + "\nPhone Number: " + phoneNum;
        }
    }
}
