using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagneticFieldsProg
{
    public partial class Form1 : Form, IVectorFieldForm
    {
        Graphics g;
        bool dot = false;
        VectorField E, B;
        public Form1()
        {
            InitializeComponent();
            E = new VectorField(new List<Charge> { new Charge(true, 100, 100, 2) });
            SetLatticePointPositions(10, E.Field);
        }
        static Vector2 _playerPos;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            
            Pen vecpen = new Pen(Brushes.Black);
            vecpen.StartCap = LineCap.RoundAnchor;
            vecpen.EndCap = LineCap.ArrowAnchor;
            vecpen.Width = 2;
            for (int i = 0; i < E.Field.GetLength(0); i++)
            {
                for (int h = 0; h < E.Field.GetLength(1); h++)
                {
                    g.TranslateTransform(E.Field[i, h].Position.X, E.Field[i, h].Position.Y, MatrixOrder.Append);
                    g.DrawLine(vecpen, new PointF(E.Field[i,h].Position.X, E.Field[i, h].Position.Y), E.Field[i, h].FieldVector.ToPointF());

                    //g.DrawEllipse(vecpen, E.Field[i, h].Position.X, E.Field[i, h].Position.Y, 1, 1);
                    g.ResetTransform();
                }
            }
        }

        public static Vector2 PlayerPos { get => _playerPos; private set => _playerPos = value; }


        public void SetLatticePointPositions(int step, LatticePoint[,] points)
        {
            for (int r = 0; r < E.Field.GetLength(0); r++) // rows
            {
                for (int c = 0; c < E.Field.GetLength(1); c++) // columns
                {
                    E.Field[r, c] = new LatticePoint(new Vector2(c * step, r * step));
                }
            }
            VectorField.SetFieldVectors(E.Field, E.Charges[0]);

        }

        public static Vector2 PolarToCartesian(float degrees)
        {
            float radians = (float)Math.PI * degrees / 180.0f;
            return new Vector2((float)Math.Sin(radians), (float)Math.Cos(radians));
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            dot = !dot;
            Invalidate();
        }

        public static void LocalToWorld(Vector2 v)
        {

        }

    }
}