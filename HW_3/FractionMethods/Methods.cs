using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_3.FractionModel;

namespace HW_3.FractionMethods
{
    struct Methods
    {
        public Fraction Plus(Fraction a, Fraction b)
        {
            if(a.Denom != b.Denom)
            {
                a.Num *= b.Denom;
                b.Num *= a.Denom;
                return new Fraction(a.Num + b.Num, a.Denom * b.Denom);
            }
            else
            {
                return new Fraction(a.Num + b.Num, a.Denom);
            }
        }

        public Fraction Multi(Fraction a, Fraction b)
        {
            return new Fraction(a.Num * b.Num, a.Denom * b.Denom);
        }

        public Fraction Subtraction(Fraction a, Fraction b)
        {
            if (a.Denom != b.Denom)
            {
                a.Num *= b.Denom;
                b.Num *= a.Denom;
                return new Fraction(a.Num - b.Num, a.Denom * b.Denom);
            }
            else
            {
                return new Fraction(a.Num - b.Num, a.Denom);
            }
        }

        public Fraction division(Fraction a, Fraction b)
        {
            return new Fraction(a.Num * b.Denom, a.Denom * b.Num);
        }

    }
}
