using System;
using System.Collections.Generic;
using System.Text;

namespace WFAOOPP
{
    class JKSTrougao : PravilnaFigura
    {
        private double a;
        public JKSTrougao(double a)
        {
            this.a = a;
        }

        public double A { get => a; set => a = value; }

        public override double Obim()
        {
            return 3 * a;
        }

        public override double Povrsina()
        {
            return a*a*Math.Sqrt(3)/4;
        }
    }
}
