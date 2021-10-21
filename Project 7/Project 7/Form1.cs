using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Source used: https://www.dreamincode.net/forums/topic/69884-array-of-images/

namespace Project_7
{
    public partial class Form1 : Form
    {
        //init global variables
        int bids = 0, totalMoney = 0;
        Random rand = new Random();
        Image[] fruitPics = new Image[10];

        public Form1()
        {
            //put the images into an array for future use
            InitializeComponent();
            fruitPics[0] = Project_7.Properties.Resources.Apple;
            fruitPics[1] = Project_7.Properties.Resources.Banana;
            fruitPics[2] = Project_7.Properties.Resources.Cherries;
            fruitPics[3] = Project_7.Properties.Resources.Grapes;
            fruitPics[4] = Project_7.Properties.Resources.Lemon;
            fruitPics[5] = Project_7.Properties.Resources.Lime;
            fruitPics[6] = Project_7.Properties.Resources.Orange;
            fruitPics[7] = Project_7.Properties.Resources.Pear;
            fruitPics[8] = Project_7.Properties.Resources.Strawberry;
            fruitPics[9] = Project_7.Properties.Resources.Watermelon;
        }

        
        //main piece of the pie
        private void roller(int bet)
        {
            //establish variables
            int[] fruitVal = new int[3];
            int winAmount;
            bids += bet;
            
            //get random values and show coresponding image
            for (int i = 0; i < fruitVal.Length; i++)
            {
                fruitVal[i] = rand.Next(0, 10);
            }
            fruitBox1.Image = fruitPics[fruitVal[0]];
            fruitBox2.Image = fruitPics[fruitVal[1]];
            fruitBox3.Image = fruitPics[fruitVal[2]];


            //check for dubs or trips and respond
            if (fruitVal[0] == fruitVal[1] && fruitVal[1] == fruitVal[2])
            {
                winAmount = bet * 3;
                resultText.Text = "Hooray!!! You tripled your money!";
            }
            else if (fruitVal[0] == fruitVal[1] || fruitVal[0] == fruitVal[2] || fruitVal[1] == fruitVal[2])
            {
                winAmount = bet * 2;
                resultText.Text = "Nice! You doubled your money!";
            }
            else
            {
                winAmount = 0;
                resultText.Text = "Oof, looks like you lost this one.";
            }
            winningText.Text = "You Won $" + winAmount.ToString();
            totalMoney += winAmount;
            updateTexts();
            resultText.Visible = true;
            winningText.Visible = true;

        }

        //updates the output text boxes
        private void updateTexts()
        {
            bankBox.Text = '$' + totalMoney.ToString();
            enteredText.Text = "You Have Entered a Total of $" + bids.ToString();
        }

        //each of the buttons when clicked does one thing
        private void oneBet_Click(object sender, EventArgs e)
        {
            roller(1);
        }

        private void fiveBet_Click(object sender, EventArgs e)
        {
            roller(5);
        }

        private void tenBet_Click(object sender, EventArgs e)
        {
            roller(10);
        }

        //resets the game back to starting state
        private void reset_Click(object sender, EventArgs e)
        {
            bids = 0;
            totalMoney = 0;
            fruitBox1.Image = fruitPics[0];
            fruitBox2.Image = fruitPics[0];
            fruitBox3.Image = fruitPics[0];
            resultText.Visible = false;
            winningText.Visible = false;
            updateTexts();
        }

        //displays money lost/gained then closes
        private void quit_Click(object sender, EventArgs e)
        {
            int dif;
            string outer;
            if (bids > totalMoney)
            {
                dif = bids - totalMoney;
                outer = "You lost $" + dif.ToString();
            }
            else if (bids == totalMoney)
            {
                outer = "You broke even";
            }
            else
            {
                dif = totalMoney - bids;
                outer = "You Won $" + dif.ToString();
            }
            MessageBox.Show(outer);
            this.Close();
        }
    }
}
