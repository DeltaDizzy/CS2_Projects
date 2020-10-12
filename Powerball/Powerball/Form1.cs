using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Powerball
{
    public partial class Form1 : Form
    {
        int numTickets = 0;
        int ticketPrice = 2;
        int resultindex = 0;
        Random r;
        string winners = "";
        int realred = 0;
        int myred = 0;
        int whiteMatches = 0;
        int redmatch = 0;
        int balance = 20000;
        int[] result = new int[12];
        // 00 01 11 21 30 31 40 41 50 51

        private void GetWinningNumbers()
        {
            // white
            // 5 random numbers, these are the white numbers
            var randomNumbers = Enumerable.Range(1, 49).OrderBy(x => x.ToString()).Take(5).ToList(); 
            // make csv list of white numbers and trim comma at the end
            for (int i = 0; i < 5; i++)
            {
                winners += $"{randomNumbers[i]},";
                winners.TrimEnd(',');
            }
            lblWhiteWinners.Text = winners;
            // powerball
            realred = r.Next(1,27);
            lblRedWinner.Text = $"{realred}";
            // txt
            // generate a hypothetical user ticket
            // random numbers from 1,49
            var ticket = Enumerable.Range(1, 49);
            for (int t = 0; t < numTickets; t++) // t = number of tickets
            {
                for (int nb = 0; nb < 5; nb++) // nb = number of ball, which white ball out of 5 are we checking?
                {
                    var thisticket = ticket.OrderBy(x => r.Next()).ToList();
                    myred = r.Next(1, 27);
                    if (randomNumbers.Contains(thisticket[nb]))
                    {
                        whiteMatches += 1;
                    }

                    if (myred == realred)
                    {
                        redmatch = 1;
                    }
                    else
                    {
                        redmatch = 0;
                    }
                }
                UpdateMatchTally();
                whiteMatches = 0;
                redmatch = 0;
            }



            winners = "";

            
        }

        private void UpdateMatchTally()
        {
            // how many matches for each
            // result is a list of how many tickets met each possiblilty
            // i.e. 5 tickets had 2 matching white numbers and 1 matching red
            resultindex = whiteMatches * 2 + redmatch;
            result[resultindex]++;
        }

        private void DisplayResults()
        {
            lstResults.Items.Clear();
            lstResults.Items.AddRange( new string[] { 
                $"{result[0]} - 0 white, 0 red", 
                $"{result[1]} - 0 white, 1 red",
                $"{result[2]} - 1 white, 0 red",
                $"{result[3]} - 1 white, 1 red",
                $"{result[4]} - 2 white, 0 red",
                $"{result[5]} - 2 white, 1 red",
                $"{result[6]} - 3 white, 0 red",
                $"{result[7]} - 3 white, 1 red",
                $"{result[8]} - 4 white, 0 red",
                $"{result[9]} - 4 white, 1 red",
                $"{result[10]} - 5 white, 0 red",
                $"{result[11]} - 5 white, 1 red"
            });
            Array.Clear(result, 0, result.Length);
            resultindex = 0;
            lblBalance.Text = $"Balance: ${balance}";
        }

        private void btnPlayIt_Click(object sender, EventArgs e)
        {
            numTickets = int.Parse(txtNumTickets.Text);
            balance -= numTickets * ticketPrice;
            GetWinningNumbers();
            AwardPrizes();
            DisplayResults();
        }
        private void AwardPrizes()
        {
            balance += result[1] * 4 + result[2] * 4 +
                result[5] * 7 + result[6] * 7 + result[7] * 100 +
                result[8] * 100 + result[9] * 50000 +
                result[10] * 1000000 + result[11] * 62000000;
        }

        public Form1()
        {
            
            r = new Random();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblWhiteWinners.Text = "";
            lblRedWinner.Text = "";
            lblBalance.Text = $"Balance: ${balance}";
        }
    }
}
