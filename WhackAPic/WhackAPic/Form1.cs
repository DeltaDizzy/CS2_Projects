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

namespace WhackAPic
{
    public partial class Form1 : Form
    {
        int startcountdown = 3;
        int gametimer = 30;
        Random r;
        int score = 0;
        int scoreKernel = 1;
        Point loc;
        Image blank;
        int mythtime = 0;
        public Form1()
        {
            InitializeComponent();
        }

        // gopher = mole
        // gem = rare
        // granite = common
        // coal = med

        private void tmrStarter_Tick(object sender, EventArgs e)
        {
            if (startcountdown <= 0)
            {
                tmrStarter.Enabled = false;
                tmrGameTimer.Enabled = true;
                tmrMover.Enabled = true;
                lblStarter.Visible = false;
                
                lblStarter.Location = new Point(1000, 1000);
                return;
            }
            startcountdown -= 1;
            lblStarter.Text = startcountdown.ToString();

        }

        private void StartCountdown()
        {
            tmrStarter.Enabled = true;
            mythtime = r.Next(1, 31);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loc = lblStarter.Location;
            r = new Random();
            StartCountdown();
            blank = pbMole.Image;
            lblScore.Text = "Score: 0";
            lblCountdown.Text = "Countdown: 30";
            lblHighScore.Text = $"High Score: {Properties.Settings.Default.highscore}";
        }

        private void tmrGameTimer_Tick(object sender, EventArgs e)
        {
            gametimer -= 1;
            lblCountdown.Text = $"Countdown: {gametimer}";

            if (gametimer == mythtime)
            {
                int x = r.Next(0, Width - pbMyth.Width);
                int y = r.Next(0, Height - pbMyth.Height - panel1.Height);
                pbMyth.Location = new Point(x, y);
                pbMyth.Visible = true;
            }
            else
            {
                pbMyth.Visible = false;
            }

            if (gametimer == 0)
            {
                EndGame();
            }
            
        }

        private void UpdateImage()
        {
            
            int picselect = r.Next(0, 3);
            switch (picselect)
            {
                case 0:
                    scoreKernel += 1;
                    pbMole.Image = Properties.Resources.granite;
                    break;
                case 1:
                    scoreKernel += 2;
                    pbMole.Image = Properties.Resources.coal;
                    break;
                case 2:
                    scoreKernel += 5;
                    pbMole.Image = Properties.Resources.gem;
                    break;
                default:
                    break;
            }
            int x = r.Next(0, Width - pbMole.Width);
            int y = r.Next(0, Height - pbMole.Height - panel1.Height);
            pbMole.Location = new Point(x, y);
            
        }

        private void EndGame()
        {
            if (score > Properties.Settings.Default.highscore)
            {
                Properties.Settings.Default.highscore = score;
                Properties.Settings.Default.Save();
                lblHighScore.Text = $"High Score: {Properties.Settings.Default.highscore}";
            }
            tmrGameTimer.Enabled = false;
            tmrMover.Enabled = false;
            lblStarter.Location = loc;
            lblStarter.Visible = true;
            lblStarter.Text = "Game Over!";
            if (MessageBox.Show("Game Over!", "Would you like to restart?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ResetGame();
            }
            else
            {
                Application.Exit();
            }
        }

        private void ResetGame()
        {
            gametimer = 30;
            startcountdown = 3;
            score = 0;
            lblScore.Text = "Score: 0";
            pbMole.Image = blank;
            StartCountdown();
            r = new Random();
        }

        private void pbMole_Click(object sender, EventArgs e)
        {
           
        }

        private void tmrMover_Tick(object sender, EventArgs e)
        {
            UpdateImage();
            tmrMover.Interval = r.Next(5, 21)*100;
            
        }

        private void pbMole_MouseDown(object sender, MouseEventArgs e)
        {
            if (tmrGameTimer.Enabled)
            {
                score += scoreKernel;
                lblScore.Text = $"Score: {score}";
            }
        }

        private void pbMyth_Click(object sender, EventArgs e)
        {
            if (tmrGameTimer.Enabled)
            {
                score += 50;
                lblScore.Text = $"Score: {score}";
            }
        }
    }
}
