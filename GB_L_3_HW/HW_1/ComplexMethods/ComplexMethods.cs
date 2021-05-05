using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_1.ComplexModel;

namespace HW_1.ComplexMethods
{
    struct Methods
    {
        public Complex Plus(Complex a, Complex b)
        {
            return new Complex(a.re + b.re, a.im + b.im);           
        }

        public Complex Multi(Complex a, Complex b)
        {          
            return new Complex(a.re * b.re - a.im * b.im, a.re * b.im + a.im * b.re);
        }

        public Complex Subtraction(Complex a, Complex b)
        {
            return new Complex(a.re - b.re, a.im - b.im);
        }
        
    }
}
