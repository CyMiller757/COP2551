using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Sources:
 * https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/how-to-initialize-objects-by-using-an-object-initializer
 * https://zetcode.com/csharp/inttostring/
 * https://docs.microsoft.com/en-us/dotnet/api/system.random?view=net-5.0
 * https://stackoverflow.com/questions/6560105/change-pictureboxs-image-to-image-from-my-resources
 */

namespace Project_4
{
    public partial class Form1 : Form
    {
        //declare global variables
        player player1 = new player();
        player player2 = new player();
        int dice1Val, dice2Val;
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
            p1Roll.Enabled = false;
            p2Roll.Enabled = false;
            
        }
        private void p1Roll_Click(object sender, EventArgs e)
        {
            //initialize turn and roll dice
            turnMessage.Visible = false;
            diceRoll();
            player1.increaseScore(dice1Val + dice2Val);

            //display score
            int p1ScorePlace;
            p1ScorePlace = player1.getScore();
            string outer = Convert.ToString(p1ScorePlace);
            p1Score.Text = outer;

            //check for doubles and respond accordingly
            if (checkDubs())
            {
                turnMessage.Text = "Dubskie!!! Roll again!\nPlayer 1 Rolls Again";
                turnMessage.Visible = true;
            }
            else
            {
                p1Roll.Enabled = false;
                p2Roll.Enabled = true;
            }

            //check if win
            if (player1.getScore() >= 50)
            {
                turnMessage.Text = "Hooray for Player 1! They Win!\nPress start to reset and play again.";
                turnMessage.Visible = true;
                p1Roll.Enabled = false;
                p2Roll.Enabled = false;
                gameStarter.Enabled = true;
            }
        }

        private void p2Roll_Click(object sender, EventArgs e)
        {
            //initialize turn and roll dice
            turnMessage.Visible = false;
            diceRoll();
            player2.increaseScore(dice1Val + dice2Val);

            //display score
            int p2ScorePlace;
            p2ScorePlace = player2.getScore();
            string outer = Convert.ToString(p2ScorePlace);
            p2Score.Text = outer;

            //check for doubles
            if (checkDubs())
            {
                turnMessage.Text = "Wowsers, You got 2 of the same die!\nPlayer 2 Rolls Again";
                turnMessage.Visible = true;
            }
            else
            {
                p1Roll.Enabled = true;
                p2Roll.Enabled = false;
            }
            //check if win
            if(player2.getScore() >= 50)
            {
                turnMessage.Text = "Hooray for Player 2! They Win!\nPress start to reset and play again.";
                turnMessage.Visible = true;
                p1Roll.Enabled = false;
                p2Roll.Enabled = false;
                gameStarter.Enabled = true;
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gameStarter_Click(object sender, EventArgs e)
        {
            //initialize new game 
            player1.resetScore();
            player2.resetScore();
            p1Score.Text = null;
            p2Score.Text = null;
            gameStarter.Enabled = false;

            //randomly determine who goes first
            //idk why it has to pull random number twice, but it doesn't work otherwise
            int whoGoFirst = rand.Next(1, 3);
            whoGoFirst = rand.Next(1, 3);
            if(whoGoFirst < 2)
            {
                p1Roll.Enabled = true;
            }
            else
            {
                p2Roll.Enabled = true;
            }
        }

        public void diceRoll()
        {
            //generate dice 1 and display respective image
            dice1Val = rand.Next(1, 6);
            switch (dice1Val)
            {
                case 1:
                    dice1Display.Image = Project_4.Properties.Resources.Die1;
                    break;
                case 2:
                    dice1Display.Image = Project_4.Properties.Resources.Die2;
                    break;
                case 3:
                    dice1Display.Image = Project_4.Properties.Resources.Die3;
                    break;
                case 4:
                    dice1Display.Image = Project_4.Properties.Resources.Die4;
                    break;
                case 5:
                    dice1Display.Image = Project_4.Properties.Resources.Die5;
                    break;
                case 6:
                    dice1Display.Image = Project_4.Properties.Resources.Die5;
                    break;

            }
            dice1Display.Visible = true;

            //generate dice 2 and display respective image
            dice2Val = rand.Next(1, 6);
            switch (dice2Val)
            {
                case 1:
                    dice2Display.Image = Project_4.Properties.Resources.Die1;
                    break;
                case 2:
                    dice2Display.Image = Project_4.Properties.Resources.Die2;
                    break;
                case 3:
                    dice2Display.Image = Project_4.Properties.Resources.Die3;
                    break;
                case 4:
                    dice2Display.Image = Project_4.Properties.Resources.Die4;
                    break;
                case 5:
                    dice2Display.Image = Project_4.Properties.Resources.Die5;
                    break;
                case 6:
                    dice2Display.Image = Project_4.Properties.Resources.Die5;
                    break;

            }
            dice2Display.Visible = true;
        }

        public bool checkDubs()
        {
            //check if dice 1 equals dice 2 and returns accordingly
            if (dice1Val == dice2Val)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class player
    {
        int score;

        //starts player with a score of 0
        public player()
        {
            score = 0;
        }

        //probably unneccissary since it wasn't utilized, but allows player to start with a specific score
        public player(int initScore)
        {
            score = initScore; 
        }
        

        //increase score
        public void increaseScore(int rollAmount)
        {
            score += rollAmount;
        }


        //returns player score
        public int getScore()
        {
            return score;
        }


        //resets player score
        public void resetScore()
        {
            score = 0;
        }
    }
}
