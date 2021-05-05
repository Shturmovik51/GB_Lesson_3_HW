using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3.FractionModel
{
    class Fraction
    {
        private int num;
        private int denom;

        public int Num { get { return num; } set { num = value; } }            // инкапсуляция
        public int Denom { get { return denom; } set {denom = value;} }
        
        public Fraction(int num, int denom)
        {
            Num = num;
            Denom = denom;
        }
    }
}
