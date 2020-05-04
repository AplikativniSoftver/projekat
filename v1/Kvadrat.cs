using System;
using System.Collections.Generic;
using System.Text;

namespace WFAOOPP
{
    class Kvadrat : PravilnaFigura
    {
        private double a;
        public Kvadrat(double a)
        {
            this.a = a;
        }

        public double A { get => a; set => a = value; }

        public override double Obim()
        {
            return 4*a;
        }

        public override double Povrsina()
        {
            return a*a;
        }
    }
}
