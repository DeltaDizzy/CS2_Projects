using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForLoops
{
    public partial class Form1 : Form
    {
        int upValue = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblUp.Text = "0";
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                upValue++;
                lblUp.Text = upValue.ToString();
                wait(1000);
                
            }
        }

        public void wait(int milliseconds)
        {
            var timer = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0)
            {
                return;
            }
            timer.Interval = milliseconds;
            timer.Enabled = true;
            timer.Start();

            timer.Tick += (s, e) =>
            {
                timer.Enabled = false;
                timer.Stop();
            };

            while(timer.Enabled)
            {
                Application.DoEvents();
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                upValue -= 2;
                lblUp.Text = upValue.ToString();
                wait(1000);
            }
        }
    }
}
