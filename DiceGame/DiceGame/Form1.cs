using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceGame
{
    public partial class Form1 : Form
    {
        int[] diceRolls = new int[5];
        PictureBox[] dice = new PictureBox[5];
        Random rng = new Random();
        Image[] images = new Image[6];

        int sum = 0;
        int score = 2000;

        public Form1()
        {
            InitializeComponent();
            dice[0] = pbDice0;
            dice[1] = pbDice1;
            dice[2] = pbDice2;
            dice[3] = pbDice3;
            dice[4] = pbDice4;
            images[0] = Properties.Resources.dice1;
            images[1] = Properties.Resources.dice2;
            images[2] = Properties.Resources.dice3;
            images[3] = Properties.Resources.dice4;
            images[4] = Properties.Resources.dice5;
            images[5] = Properties.Resources.dice6;
            lblScore.Text = "2000";
            lblSum.Text = "0";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // determine rolls
            for (int r = 1; r < 5; r++)
            {
                // result
                diceRolls[r] = rng.Next(1, 7);
                ((PictureBox)this.Controls["pbDice" + r.ToString()]).Image = (Image)Properties.Resources.ResourceManager.GetObject($"dice{diceRolls[r]}");
                sum += diceRolls[r];
                if (score < 0)
                {
                    score = 0;
                    UpdateScore();
                    break;
                }
                if (r > 1)
                {
                    if (diceRolls[r] == diceRolls[r - 1])
                    {
                        score += 5000;
                    }
                }
                UpdateScore();
            }
            sum = 0;
        }

        private void UpdateScore()
        {
            if (sum is 5 || sum is 30)
            {
                score += 10000;
            }
            else if (sum > 14 && sum < 18)
            {
                score += 2000;
            }
            else if (sum is 20)
            {
                score += 500;
            }
            else if (sum is 12 || sum is 22)
            {
                score -= 1000;
            }
            else if (sum is 18 || sum is 25)
            {
                score /= 2;
            }
            else if (sum is 10 || sum is 16 || sum is 24)
            {
                score += 500;
            }
            else
            {
                score -= 250;
            }

            lblScore.Text = score.ToString();
            lblSum.Text = sum.ToString();
        }

    }
}
