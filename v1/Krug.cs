using System;
using System.Collections.Generic;
using System.Text;

namespace WFAOOPP
{
    class Krug : PravilnaFigura
    {
        private double a;
        public Krug(double a)
        {
            this.a = a;
        }

        public double A { get => a; set => a = value; }

        public override double Obim()
        {
            return 2 * a * Math.PI;
        }

        public override double Povrsina()
        {
            return a * a * Math.PI;
        }
    }
}
