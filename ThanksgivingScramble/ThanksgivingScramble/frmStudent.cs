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
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }

        Random r = new Random();
        List<string> origwords = new List<string>();

        private void frmStudent_Load(object sender, EventArgs e)
        {
            origwords = util.unscrambledWords.Take(5).ToList();

            for (int i = 0; i < 5; i++)
            {
                int word = r.Next(0, origwords.Count - 1);
                string n = new string(origwords[word].ToCharArray()
                    .OrderBy(s => (r.Next(2) % 2) == 0).ToArray());
                this.Controls[$"label{i}"].Text = n;
                n = "";
                origwords.RemoveAt(i);
            }
        }
    }
}
