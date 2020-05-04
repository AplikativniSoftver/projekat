using System;
using System.Collections.Generic;
using System.Text;

namespace WFAOOPP
{
    abstract class PravilnaFigura
    {
        public abstract double Povrsina();
        public abstract double Obim();

        public static string GetName() 
        {
            return "Dobrodosli!!!\nUnesite neki broj";        
        }
    }
}
