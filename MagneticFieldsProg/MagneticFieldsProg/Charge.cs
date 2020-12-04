using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MagneticFieldsProg
{
    public class Charge
    {
        bool _positive;
        Vector2 _pos;
        int _strength;

        public Charge(bool positive, Vector2 position, int strength)
        {
            Positive = positive;
            Pos = position;
            Strength = strength;
        }

        public Charge(bool positive, int x, int y, int strength)
        {
            Positive = positive;
            Pos = new Vector2(x,y);
            Strength = strength;
        }

        public bool Positive { get => _positive; private set => _positive = value; }
        public Vector2 Pos { get => _pos; private set => _pos = value; }
        public int Strength { get => _strength; private set => _strength = value; }
    }
}
