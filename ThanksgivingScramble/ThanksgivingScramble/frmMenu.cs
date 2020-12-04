using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThanksgivingScramble
{
    public partial class frmMenu : Form
    {
        Random r = new Random();
        frmTeacher teach;
        frmStudent student;

        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            teach = new frmTeacher();
            teach.Show();
        }
    }
}
