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
 * 
 * 
 */

namespace Project_4
{
    public partial class Form1 : Form
    {
        player player1 = new player();
        player player2 = new player();
        int dice1Val, dice2Val;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void p2Roll_Click(object sender, EventArgs e)
        {
            diceRoll();
            player1.increaseScore(dice1Val + dice2Val);
        }

        private void p1Roll_Click(object sender, EventArgs e)
        {
            int test;
            test = player1.getScore();
            string outer = Convert.ToString(test);
            p2Score.Text = outer;
        }

        public void diceRoll()
        {
            Random rand = new Random();
            dice1Val = rand.Next(1, 6);
            dice2Val = rand.Next(1, 6);
        }
    }

    public class player
    {
        int score;

        public player()
        {
            score = 0;
        }
        public player(int initScore)
        {
            score = initScore;
        }
        
        public void increaseScore(int rollAmount)
        {
            score += rollAmount;
        }

        public int getScore()
        {
            return score;
        }

        public void resetScore()
        {
            score = 0;
        }
    }
}
