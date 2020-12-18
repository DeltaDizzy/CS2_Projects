using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MagneticFieldsProg
{
    public struct PlayerPhysicsState
    {
        private Vector2 _position, _velocity, _force;
        private double _angularVelocity, _torque, _mass, _inertia, _coeff_fric;
        private bool _charged;

        public Vector2 Position { get => _position; set => _position = value; }
        public Vector2 Velocity { get => _velocity; set => _velocity = value; }
        public Vector2 Force { get => _force; set => _force = value; }
        public double AngularVelocity { get => _angularVelocity; set => _angularVelocity = value; }
        public double Torque { get => _torque; set => _torque = value; }
        public double Mass { get => _mass; set => _mass = value; }
        public double Inertia { get => _inertia; set => _inertia = value; }
        public double Mu_Friction { get => _coeff_fric; set => _coeff_fric = value; }
        public bool Charged { get => _charged; set => _charged = value; }
    }
}
