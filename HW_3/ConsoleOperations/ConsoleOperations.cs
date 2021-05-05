using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_3.FractionModel;
using HW_3.FractionMethods;

namespace HW_3.ConsoleOperations
{
    class Print
    {
        public void StartProgramm(Fraction a, Fraction b)
        {
            Methods method = new Methods();

            Console.WriteLine("\nКакую операцию произвести?\n 1: Сложение,  2: Вычитание,  3: Умножение, 4: Деление, 5: Выход");
                        
            switch (FoolProtectionInput())    
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
                    Console.WriteLine($"({ToString(a)}):({ToString(b)}) = {ToString(method.division(a, b))}");    
                    StartProgramm(a, b);    
                    break;    
                case (5):    
                    break;    
                default:    
                    Console.WriteLine("Soon in Update");    
                    StartProgramm(a, b);    
                    break;    
            } 
        }

        public string ToString(Fraction a)  // вывод дроби
        {
            return $"{a.Num}/{a.Denom}";
        }

        public int FoolProtectionInput()    // защита от вода нечисловых значений
        {
            bool notFool = false;
            int num = 0;

            while (!notFool)
            {
                notFool = int.TryParse(Console.ReadLine(), out int number);
                if (!notFool) Console.WriteLine("Дубина, введи цифру");
                num = number;
            }
            return num;
        }
    }
}
