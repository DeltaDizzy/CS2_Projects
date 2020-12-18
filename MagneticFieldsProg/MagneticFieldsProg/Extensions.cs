using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MagneticFieldsProg
{
    public static class Extensions
    {
        public static PointF ToPointF(this Vector2 vec)
        {
            return new PointF(vec.X, vec.Y);
        }

        public static Vector2 DivideByScalar(this Vector2 a, float b)
        {
            return new Vector2(a.X / b, a.Y / b);
        }

        public static Vector2 MultiplyByScalar(this Vector2 a, float b)
        {
            return new Vector2(a.X * b, a.Y * b);
        }
    }

    public class Overrides
    {
        
    }
}
