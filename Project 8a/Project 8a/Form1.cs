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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] nameAndYear = System.IO.File.ReadAllLines("Names.txt");
            int size = nameAndYear.Length, temp, year;
            string name;

            student[] peoples = new student[size];
            for (int i = 0; i < size; i++)
            {
                temp = nameAndYear[i].Length - 4;
                name = nameAndYear[i].Substring(0, temp);
                year = int.Parse(nameAndYear[i].Substring(temp));
                peoples[i] = new student(name, year);
                studentSelection.Items.Add(name + year.ToString());
            }
        }

    }
    public class student
    {
        private string name;
        private int year;
        public student(string n, int y)
        {
            name = n;
            year = y;
        }

        public string getName()
        {
            return name;
        }
        
        public int getYear()
        {
            return year;
        }
    }
}
