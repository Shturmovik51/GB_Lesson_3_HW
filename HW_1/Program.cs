using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_1.ConsoleOperations;
using HW_1.ComplexModel;

namespace HW_1
{    
    class Program
    {        
        static void Main(string[] args)
        {
            Print please = new Print();

            Console.WriteLine("Введите действительную части комплексного числа А");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите мнимую части комплексного числа А");
            double x2 = double.Parse(Console.ReadLine());
            Complex complex1 = new Complex(x1, x2);

            Console.WriteLine("Введите действительную части комплексного числа B");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите мнимую части комплексного числа B");
            double y2 = double.Parse(Console.ReadLine());
            Complex complex2 = new Complex(y1, y2);

            please.StartProgramm(complex1, complex2);

        }
    }
}
