using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
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
    }
}
