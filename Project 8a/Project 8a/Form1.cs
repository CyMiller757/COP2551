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
 * https://docs.microsoft.com/en-us/dotnet/api/system.string.substring?view=net-5.0
 * 
 * 
 * 
 */

namespace Project_8a
{
    public partial class Form1 : Form
    {
        //need this globablly for later purposes
        Student[] peoples;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //establish variables and import txt file
            string[] nameAndYear = System.IO.File.ReadAllLines("Names.txt");
            int size = nameAndYear.Length, temp, year;
            string name;
            Array.Sort(nameAndYear);

            //put the data into an array of student objects and add to the list
            peoples = new Student[size];
            for (int i = 0; i < size; i++)
            {
                temp = nameAndYear[i].Length - 4;
                name = nameAndYear[i].Substring(0, temp);
                year = int.Parse(nameAndYear[i].Substring(temp));
                peoples[i] = new Student(name, year);
                studentSelection.Items.Add(name + year.ToString());
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //establish variable and clear output incase of previous search
            int search;
            searchOutput.Items.Clear();

            //try to turn string inputed into box into an integer
            if(int.TryParse(searchInput.Text, out search))
            {
                //check through all students to find matching year and add to output if so
                foreach (Student i in peoples)
                {
                    if(i.getYear() == search)
                    {
                        searchOutput.Items.Add(i.getName());
                    }
                }
            }
            //handle bad input
            else
            {
                MessageBox.Show("Please enter a valid year in the search box!");
            }

            //handle no results found
            if(searchOutput.Items.Count == 0)
            {
                searchOutput.Items.Add("No Matching");
                searchOutput.Items.Add("Students found");
            }
        }

        //the fun button
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


    //students are in class
    public class Student
    {
        //declare variables associated with students
        private string name;
        private int year;

        //initiator for students
        public Student(string n, int y)
        {
            name = n;
            year = y;
        }

        //return name
        public string getName()
        {
            return name;
        }
        

        //return year of born
        public int getYear()
        {
            return year;
        }
    }
}
