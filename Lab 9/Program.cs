using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine(a / b);
            }
            catch
            {
                Console.WriteLine("Misstake");
            }
            Console.ReadKey();
        }
    }
}
