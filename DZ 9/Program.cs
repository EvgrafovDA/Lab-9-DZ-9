using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_9
{
    internal class Program
    {
        private static float answer;

        static void Main(string[] args)
        {
            double a, b, c; char h; c = 0.0;
            Console.WriteLine("Введите первое число для вычисления:");
            string s = Console.ReadLine();
            float a = float.Parse(s);

            Console.WriteLine("Введите второе число для вычисления:");
            string s2 = Console.ReadLine();
            float b = float.Parse(s2);            
            Console.WriteLine("Введите требуемое дейсивие (+,-,/,*)=");

            float c = Convert.ToInt32(Console.ReadLine());
            switch (c)
            {
                case '+':
                    answer = a + b;
                    break;
                case '-':
                    answer = a - b;
                    break;
                case '*':
                    answer = a * b;
                    break;
                case '/':
                    answer = a / b;
                    break;
                    default: throw new Exception();
            }
            Console.WriteLine("Ответ {0}:", answer.ToString());
            Console.ReadLine();
        }
    }
}
