using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_3.FractionModel;
using HW_3.ConsoleOperations;

namespace HW_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Print please = new Print();

            Console.WriteLine("Введите числитель дроби А");
            int x1 = please.FoolProtectionInput();           
            int x2 = 0 ;

            while(x2 == 0)  //проверка знаменателя на 0
            {
                Console.WriteLine("Введите знаменатель дроби А");
                x2 = please.FoolProtectionInput();
                if (x2==0) Console.WriteLine("Знаменатель не может быть равен 0");
            }

            Console.WriteLine("Введите числитель дроби B");
            int y1 = please.FoolProtectionInput();
            int y2 = 0;

            while (y2 == 0)
            {
                Console.WriteLine("Введите знаменатель дроби B");
                y2 = please.FoolProtectionInput();
                if (y2 == 0) Console.WriteLine("Знаменатель не может быть равен 0");
            }
            
            Fraction fraction1 = new Fraction(x1, x2);
            Fraction fraction2 = new Fraction(y1, y2);

            please.StartProgramm(fraction1, fraction2);
        }
    }
}
