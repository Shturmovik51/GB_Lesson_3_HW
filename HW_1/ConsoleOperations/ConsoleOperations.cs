using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_1.ComplexModel;
using HW_1.ComplexMethods;

namespace HW_1.ConsoleOperations
{
    public class Print
    {
        public void StartProgramm(Complex a, Complex b)
        {
            Methods method = new Methods();
            
            Console.WriteLine("\nКакую операцию произвести?\n 1: Сложение,  2: Вычитание,  3: Умножение, 4: Выход");
            int number;
            bool notFool = int.TryParse(Console.ReadLine(), out number);

            if (notFool)
            {
                switch (number)
                {
                    case (1):
                        Console.WriteLine($"({ToString(a)})+({ToString(b)}) = {ToString(method.Plus(a, b))}");
                        StartProgramm(a, b);
                        break;
                    case (2):
                        Console.WriteLine($"({ToString(a)})-({ToString(b)}) = {ToString(method.Subtraction(a, b))}");
                        StartProgramm(a, b);
                        break;
                    case (3):
                        Console.WriteLine($"({ToString(a)})*({ToString(b)}) = {ToString(method.Multi(a, b))}");
                        StartProgramm(a, b);
                        break;
                    case (4):
                        break;
                    default:
                        Console.WriteLine("Soon in Update");
                        StartProgramm(a, b);
                        break;
                }
            }
            else
            {
                Console.WriteLine("Дубина, введи цифру");
                StartProgramm(a, b);
            }
            
        }
        
        public string ToString(Complex a)
        {
            return $"{a.re} + {a.im}i";
        }
    }
}
