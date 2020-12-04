using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagneticFieldsProg
{
    public class VectorField
    {
        static int width = 1000;
        static int height = 1000;
        public static int step = 10;
        const int playercharge = 1;
        const double Ke = 8.988e+9;
        const double e0 = 8.8541878128e-12;

        public LatticePoint[,] Field { get; set; } = new LatticePoint[width / 10, height / 10];
        public List<Charge> Charges { get; set; } = new List<Charge>();

        public VectorField()
        {
            // no args, set it to zero
            for (int r = 0; r < Field.GetLength(0); r++) // rows
            {
                for (int c = 0; c < Field.GetLength(1); c++) // columns
                {
                    Field[r, c] = new LatticePoint(new Vector2(c*10, r*10));
                }
            }
        }
        public VectorField(List<Charge> charges)
        {
            for (int r = 0; r < Field.GetLength(0); r++) // rows
            {
                for (int c = 0; c < Field.GetLength(1); c++) // columns
                {
                    Field[r, c] = new LatticePoint(new Vector2(c * 10, r * 10));
                }
            }
            // calculate field at every point
            // THIS IS JUST NBODY 2 HAHA
            for (int i = 0; i < charges.Count; i++)
            {
                // for each charge find the field vector at every grid point
                for (int r = 0; r < Field.GetLength(0); r++)
                {
                    for (int c = 0; c < Field.GetLength(1); c++)
                    {
                        Field[r, c].FieldVector += CalculateCoulombForce(charges[i], Field[r,c].Position);
                    }
                }
            }

            Charges = charges;
        }

        private Vector2 CalculateCoulombForce(Charge charge, Vector2 latticePoint)
        {
            Vector2 force, distance, axis;
            distance = latticePoint - charge.Pos;
            axis = distance / distance.LengthSquared();
            force = MultiplyVector(axis / distance.LengthSquared(), charge.Strength/(float)(4 * Math.PI * e0));
            return force;
        }

        public void SetUniform(int strength, Vector2 dir)
        {
            foreach (LatticePoint lp in Field)
            {
                lp.FieldVector = PolarToCartesian(0);
            }
        }

        public static Vector2 PolarToCartesian(float degrees)
        {
            float radians = (float)Math.PI * degrees / 180.0f;
            return new Vector2((float)Math.Sin(radians), (float)Math.Cos(radians));
        }

        private static Vector2 MultiplyVector(Vector2 vec, float scalar)
        {
            return new Vector2(vec.X * scalar, vec.Y * scalar);
        }

        public static void SetFieldVectors(LatticePoint[,] a, Charge c)
        {
            foreach (LatticePoint p in a)
            {
                float dx = p.Position.X - c.Pos.X, dy = p.Position.Y - c.Pos.Y;
                float r2 = (float)Math.Pow(dx, 2) + (float)Math.Pow(dy, 2);
                p.FieldVector = MultiplyVector(Vector2.Normalize(new Vector2(dx, dy)), 0.1f);
            }
        }

    }
}
