using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardestGame
{
    public partial class frm2 : Form
    {
        List<Panel> walls = new List<Panel>();
        List<Label> blues = new List<Label>();
        Label[] blueGroupA, blueGroupB;
        Point start, prev;
        bool right, left, up, down = false;
        bool AUp = true;
        int bluespeed = 4;
        int playerspeed = 5;

        private void tmeMovement_Tick(object sender, EventArgs e) // tme was a typo
        {
            if (down)
            {
                lblPlayer.Top += playerspeed;
            }
            if (up)
            {
                lblPlayer.Top -= playerspeed;
            }
            if (right)
            {
                lblPlayer.Left += playerspeed;
            }
            if (left)
            {
                lblPlayer.Left -= playerspeed;
            }
            prev = lblPlayer.Location;
            CheckCollisions(lblPlayer);
            CheckCollisions(blue3);
            CheckCollisions(blue1);
            MoveBlues();
        }

        void CheckCollisions(Label checker)
        {
            if (checker == lblPlayer)
            {
                for (int i = 0; i < walls.Count; i++)
                {
                    if (checker.Bounds.IntersectsWith(walls[i].Bounds))
                    {
                        checker.Location = prev;
                    }
                }

                for (int i = 0; i < blues.Count; i++)
                {
                    if (lblPlayer.Bounds.IntersectsWith(blues[i].Bounds))
                    {
                        lblPlayer.Location = start;
                        lives -= 1;
                    }
                }

                if (lblPlayer.Bounds.IntersectsWith(pnlEndpoint.Bounds))
                {
                    LevelEnd(true);
                }
            }

            if (blues.Contains(checker))
            {
                for (int i = 0; i < walls.Count; i++)
                {
                    if (checker.Bounds.IntersectsWith(walls[i].Bounds))
                    {
                        if (AUp == true)
                        {
                            AUp = false;
                        }
                        else if (AUp == false)
                        {
                            AUp = true;
                        }
                    }
                }
            }
        }

        private void MoveBlues()
        {
            for (int i = 0; i < blues.Count; i++)
            {
                if (blueGroupA.Contains(blues[i]))
                {

                    // in group a
                    if (AUp == true)
                    {
                        blues[i].Top -= bluespeed;
                    }
                    else
                    {

                        blues[i].Top += bluespeed;
                    }
                }
                else if (blueGroupB.Contains(blues[i])) // in group b
                {
                    if (AUp == true)
                    {
                        blues[i].Top += bluespeed;
                    }
                    else
                    {
                        blues[i].Top -= bluespeed;
                    }
                }
            }
        }

        private void LevelEnd(bool win)
        {
            tmeMovement.Enabled = false;
            if (win)
            {
                /*DialogResult box = MessageBox.Show("You Win! Would you like to go to the next level (Yes) or quit (No)?", "Level Beat", MessageBoxButtons.YesNo);
                if (box == DialogResult.Yes)
                {
                    this.Hide();
                    level2.Show();
                }
                else if (box == DialogResult.No)
                {
                    Application.Exit();
                }*/

                if(MessageBox.Show("YOU DID IT!", "", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }

        int lives = 5;
        public frm2()
        {
            InitializeComponent();
        }

        private void frm2_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    up = false;
                    break;
                case Keys.A:
                    left = false;
                    break;
                case Keys.S:
                    down = false;
                    break;
                case Keys.D:
                    right = false;
                    break;
                default:
                    break;
            }
        }

        private void frm2_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    up = true;
                    break;
                case Keys.A:
                    left = true;
                    break;
                case Keys.S:
                    down = true;
                    break;
                case Keys.D:
                    right = true;
                    break;
                default:
                    break;
            }
        }

        private void frm2_Load(object sender, EventArgs e)
        {
            IEnumerable<Label> query = from item in this.Controls.OfType<Label>()
                                       where item.Name.Contains("blue")
                                       orderby item.Name
                                       select item;
            blueGroupA = new Label[3];
            blueGroupB = new Label[2];
            blues = query.ToList();
            blueGroupA[0] = blues[0];
            blueGroupB[0] = blues[1];
            blueGroupA[1] = blues[2];
            blueGroupB[1] = blues[3];
            blueGroupB[2] = blues[4];
            //walls = this.Controls.OfType<Panel>().OrderBy(x => x.Name).ToList();
            //walls.Remove(pnlEndpoint);
            walls.AddRange(new Panel[] { panel2, panel3, panel4, panel5, panel6 });
            start = lblPlayer.Location;
        }
    }
}
