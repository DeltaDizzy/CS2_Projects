using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUpgrade
{
    public partial class Form1 : Form
    {
        int[] players = new int[9];
        List<int> runs = new List<int>();
        Random r = new Random();
        int minUnfilledPlayer = 0;
        int iterations = 0;
        int numRuns;
        private int GetPlayers()
        {
            while (true)
            {
                if (minUnfilledPlayer <= 8)
                {
                    int nextPlayerNumber = r.Next(1, 10);
                    if (!players.Contains(nextPlayerNumber))
                    {
                        players[minUnfilledPlayer] = nextPlayerNumber;
                        minUnfilledPlayer++;
                    }
                    iterations++;
                }
                else
                {
                    return iterations;
                }
            }

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            lstArray.Items.Clear();
            int.TryParse(txtNumRuns.Text, out int numRuns);
            runs.Clear();
            lstRuns.Items.Clear();
            string[] runsoutput = new string[numRuns];
            for (int i = 0; i < numRuns; i++)
            {
                runs.Add(GetPlayers());
                iterations = 0;
                minUnfilledPlayer = 0;
                Array.Clear(players, 0, 9);
            }
            foreach (var item in runs)
            {
                runsoutput[runs.IndexOf(item)] = $"Run {runs.IndexOf(item)+1}: {item}\n";
            }

            if (!runsoutput.Contains(null))
            {
                lstRuns.Items.AddRange(runsoutput);
            }
            ShowArray(runsoutput);
        }

        private void ShowArray(string[] array)
        {
            foreach (string item in array)
            {
                if (item != null)
                {
                    lstArray.Items.Add(item);
                }
                else
                {
                    throw new ArgumentNullException($"Item at index {item.}");
                    lstArray.Items.Add("null");
                }
            }
        }
    }
}
