using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_9._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Простой калькулятор - выполняйте инструкции программы ");
            while (true)
            {
                double a, b, c; char h; c = 0.0;
                try
                {
                    Console.WriteLine("введите первое число "); 
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("введите второе число "); 
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("введите операцию (+) (-) (*) (/)");
                    h = Convert.ToChar(Console.ReadLine());
                    switch (h)
                    {
                        case '+':
                            c = a + b;
                            break;
                        case '-':
                            c = a - b;
                            break;
                        case '/':
                            c = a / b;
                            break;
                        case '*':
                            c = a * b;
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Введено недопустимое значение, попробуйте ещё раз");
                }
                Console.WriteLine();
                Console.WriteLine("Начать заново? (y/n)");
                ConsoleKeyInfo e = Console.ReadKey();
                if (e.KeyChar == 'n') break;
                Console.WriteLine();
            }
        }
    }
}
