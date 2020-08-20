using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORLOOPSCHALLENGE
{
    public partial class Form1 : Form
    {
        int start, end, countby;

        private void btnCount_Click(object sender, EventArgs e)
        {
            GetNumbers();

            ShowNumbers();
        }

        public void GetNumbers()
        {
            start = int.Parse(txtFrom.Text);
            end = int.Parse(txtTo.Text);
            countby = int.Parse(txtBy.Text);
        }

        public void ShowNumbers()
        {
            for (int i = start; i <= end; i+=countby)
            {
                lstNumbers.Items.Add(i);
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

            while (timer.Enabled)
            {
                Application.DoEvents();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
