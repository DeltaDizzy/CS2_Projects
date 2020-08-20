using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpSyntax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textboxes = this.Controls.Find("txt", true) as TextBox[];
        }

        int[,] numbers = new int[3, 3];
        bool allUnique;
        List<int> duplicates = new List<int>();
        bool[] textFill = new bool[9];
        TextBox[] textboxes = new TextBox[9];



        private void button1_Click(object sender, EventArgs e)
        {
            // get numbers

            textFill[0] = int.TryParse(txtUpperLeft.Text, out int topleft);
            textFill[1] = int.TryParse(txtUpperCenter.Text, out int topmid);
            textFill[2] = int.TryParse(txtUpperRight.Text, out int topright);
            textFill[3] = int.TryParse(txtCenterLeft.Text, out int midleft);
            textFill[4] = int.TryParse(txtCenterCenter.Text, out int midmid);
            textFill[5] = int.TryParse(txtCenterRight.Text, out int midright);
            textFill[6] = int.TryParse(txtBottomLeft.Text, out int btmleft);
            textFill[7] = int.TryParse(txtBottomCenter.Text, out int btmmid);
            textFill[8] = int.TryParse(txtBottomRight.Text, out int btmright);

            if (!textFill.Contains(false))
            {
                numbers[0, 0] = topleft;
                numbers[0, 1] = topmid;
                numbers[0, 2] = topright;
                numbers[1, 0] = midleft;
                numbers[1, 1] = midmid;
                numbers[1, 2] = midright;
                numbers[2, 0] = btmleft;
                numbers[2, 1] = btmmid;
                numbers[2, 2] = btmright;
            }
            else
            {
                MessageBox.Show("Enter a number in all text boxes.");
                return;
            }

            HashSet<int> uniqueCheck = new HashSet<int>();

            foreach (int item in numbers)
            {
                // try to add, see if item is already present in hashset
                if (!uniqueCheck.Add(item))
                {
                    duplicates.Add(item);
                }
            }
            if (duplicates.Any())
            {
                allUnique = false;
            }
            else
            {
                allUnique = true;
            }

            // check numbers
            bool[] lineChecks = new bool[8];

            // rows
            for (int i = 0; i < 3; i++)
            {
                lineChecks[i] = (numbers[i, 0] + numbers[i, 1] + numbers[i, 2] == 15);
            }

            // columns
            for (int i = 0; i < 3; i++)
            {
                lineChecks[i + 3] = (numbers[0, i] + numbers[1, i] + numbers[2, i] == 15);
            }

            lineChecks[6] = (numbers[0, 0] + numbers[1, 1] + numbers[2, 2] == 15);
            lineChecks[7] = (numbers[2, 0] + numbers[1, 1] + numbers[0, 2] == 15);

            if ((!lineChecks.Contains(false) && allUnique == true))
            {
                MessageBox.Show("mAGIC");
            }
        }
    }
}
