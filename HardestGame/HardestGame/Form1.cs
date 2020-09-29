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
    public partial class Form1 : Form
    {
        int speed = 5;
        int lives = 5;
        int bluespeed = 4;
        static List<Label> blues = new List<Label>();
        List<Panel> walls = new List<Panel>();
        bool right, left, up, down = false;
        bool ALeft = true;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
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

        private void Form1_KeyUp(object sender, KeyEventArgs e)
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

        Point prev;

        Label[] groupA;
        Label[] groupB;
        private void tmrMovement_Tick(object sender, EventArgs e)
        {
            if (down)
            {
                lblPlayer.Top += speed;
            }
            if (up)
            {
                lblPlayer.Top -= speed;
            }
            if (right)
            {
                lblPlayer.Left += speed;
            }
            if (left)
            {
                lblPlayer.Left -= speed;
            }

            CheckCollisions(lblPlayer);
            MoveBlues();
            for (int i = 0; i < blues.Count; i++)
            {
                CheckCollisions(blues[i]);
            }
            
            
        }

        private void MoveBlues()
        {
            for (int i = 0; i < blues.Count; i++)
            {
                if (groupA.Contains(blues[i]))
                {
                    // in group a
                    if (ALeft == true)
                    {
                        blues[i].Left -= bluespeed;
                    }
                    else
                    {
                        blues[i].Left += bluespeed;
                    }
                }
                else if (groupB.Contains(blues[i])) // in group b
                {
                    if (ALeft == true)
                    {
                        blues[i].Left += bluespeed;
                    }
                    else
                    {
                        blues[i].Left -= bluespeed;
                    }
                }
            }
        }

        void CheckCollisions(Label checker)
        {
            if (checker == lblPlayer)
            {
                for (int i = 0; i < walls.Count; i++)
                {
                    if (checker.Bounds.IntersectsWith(walls[i].Bounds))
                    {
                        prev = new Point(checker.Location.X - speed, checker.Location.Y - speed);
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
            }

            if (blues.Contains(checker))
            {
                for (int i = 0; i < walls.Count; i++)
                {
                    if (checker.Bounds.IntersectsWith(walls[i].Bounds))
                    {
                        if (ALeft == true)
                        {
                            ALeft = false;
                        }
                        else if (ALeft == false)
                        {
                            ALeft = true;
                        }
                    }
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        Point start;

        private void Form1_Load(object sender, EventArgs e)
        {
            IEnumerable<Label> query = from item in this.Controls.OfType<Label>()
                                       where item.Name.Contains("blue")
                                       select item;
            blues = query.ToList();
            groupA = new Label[2];
            groupA[0] = blue1;
            groupA[1] = blue2;
            groupB = new Label[2];
            groupB[0] = blue3;
            groupB[1] = blue4;

            walls = this.Controls.OfType<Panel>().OrderBy(x => x.Name).ToList();
            start = lblPlayer.Location;
        }
    }
}
