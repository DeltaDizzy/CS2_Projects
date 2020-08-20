using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace GetMeOuttaHere
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // group controls
            Panel[] walls = Controls
     .OfType<Panel>()
     .Where(panel => {
         // Given a panel you have to decide should you add it to array or not
         var match = Regex.Match(panel.Name, "^panel(?<num>[0-9]+)$");

         return match.Success &&
                int.Parse(match.Groups["num"].Value) >= 0 &&
                int.Parse(match.Groups["num"].Value) <= 42;
     })
     .ToArray();
            MessageBox.Show(walls[5].Name.ToString());
        }
    }
}
