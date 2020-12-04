using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagneticFieldsProg
{
    interface IVectorFieldForm
    {
        void SetLatticePointPositions(int step, LatticePoint[,] points);
    }
}
