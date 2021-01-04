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
        Player p = new Player(new PlayerPhysicsState());
        float deltaTime = 0.01f;
        VectorField E, B;
        List<Charge> charges = new List<Charge> { new Charge(true, 10, 10, 5), new Charge(false, 20, 20, 5) };
        Vector2 oldpos;
        public Form1()
        {
            InitializeComponent();
            E = new VectorField(charges);
            SetLatticePointPositions(10, E.Field);
        }

        #region Drawing the Field
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
                    g.DrawLine(vecpen, E.Field[i,h].Position.ToPointF(), (E.Field[i, h].Position + E.Field[i, h].FieldVector * VectorField.step).ToPointF());

                    g.DrawEllipse(vecpen, E.Field[i, h].Position.X, E.Field[i, h].Position.Y, 1, 1);
                    g.ResetTransform();
                }
            }
        }

        public void SetLatticePointPositions(int step, LatticePoint[,] points)
        {
            for (int r = 0; r < E.Field.GetLength(0); r++) // rows
            {
                for (int c = 0; c < E.Field.GetLength(1); c++) // columns
                {
                    E.Field[r, c] = new LatticePoint(new Vector2(c * step, r * step));
                }
            }

            //VectorField.SetFieldVectors(E.Field, E.Charges);
            VectorField.SetUniform(45, 1, E, Width, 0);

        }

        public static Vector2 PolarToCartesian(float degrees)
        {
            float radians = (float)Math.PI * degrees / 180.0f;
            return new Vector2((float)Math.Sin(radians), (float)Math.Cos(radians));
        }

        
        #endregion

        #region Player Movement
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
        }

        private void Form1_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void tmrIntegrator_Tick(object sender, EventArgs e)
        {

        }
        #endregion
    }
}