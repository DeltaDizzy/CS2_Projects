using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stopwatch
{
    public partial class Form1 : Form
    {
        int tenth,second,minute = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e) // start/stop
        {
            tmrTenth.Enabled = !tmrTenth.Enabled;
        }

        private void pictureBox2_Click(object sender, EventArgs e) // split
        {
            string time = $"{lblMinute.Text}{lblSeconds.Text}{lblTenth.Text}";
            lstSplits.Items.Add(time);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            lstSplits.Items.Clear();
            tenth = 0;
            minute = 0;
            second = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tmrTenth_Tick(object sender, EventArgs e)
        {
            lblTenth.Text = tenth.ToString();
            tenth++;
            if (tenth == 9)
            {
                tenth = 0;
                second++;
                lblSeconds.Text = second.ToString("0#:");
            }
            if (second == 9)
            {
                second = 0;
                minute++;
                lblMinute.Text = minute.ToString("0#:");
            }
        }
    }
}
