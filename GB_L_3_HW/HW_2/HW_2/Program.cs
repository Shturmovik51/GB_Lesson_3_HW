using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вводите числа, стопцифра - 0");
            float summOfNumbers = 0;
            float number = 1; 
                                        

            while (number != 0)
            {
                bool notFool = EnterNumber(ref number);

                if (notFool)
                {
                    summOfNumbers += Summ(number);
                }
                else
                {
                    Console.WriteLine("Ошибка ввода");                   
                }
            }

            Console.WriteLine($"Сумма всех нечетных положительных чисел = {summOfNumbers}");
                       
        }
        static float Summ(float a)
        {
            if (a % 2 == 0 || a < 0)
                return 0;
            else
                return a;            
        }

        static bool EnterNumber(ref float x)
        {
            bool f = float.TryParse(Console.ReadLine(), out float num);
            if(f)
                x = num;
            return f;
        }
    }
}
