using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagneticFieldsProg
{
    public partial class ChargeControl : PictureBox
    {
        public ChargeControl()
        {
            InitializeComponent();
        }
        int _strength = 1;

        public int Strength { get => _strength; set => _strength = value; }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
