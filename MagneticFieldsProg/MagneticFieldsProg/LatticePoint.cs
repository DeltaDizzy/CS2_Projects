using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MagneticFieldsProg
{
    public class LatticePoint
    {
        Vector2 _position;
        Vector2 _fieldVector;

        public LatticePoint()
        {
            Position = new Vector2(0);
            FieldVector = new Vector2(0);
        }

        public LatticePoint(Vector2 position)
        {
            Position = position;
            FieldVector = new Vector2(0);
        }

        public LatticePoint(int x, int y)
        {
            Position = new Vector2(x,y);
            FieldVector = new Vector2(0);
        }

        public Vector2 Position { get => _position; private set => _position = value; }
        public Vector2 FieldVector { get => GetVector(_fieldVector); set => _fieldVector = value; }

        private Vector2 GetVector(Vector2 v)
        {
            return Vector2.Normalize(v);
        }

    }
}
