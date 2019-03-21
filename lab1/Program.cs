using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            
                int x, y;
                double z;

                //x- первое числа
                //y - второе числа
                // z - Решение.
                Console.WriteLine("Введите ваше первое  число.");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ваше число : " + x);
                Console.WriteLine("Введите ваше второе число.");
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ваше число : " + y);
                z = Math.Pow(x, 2) + Math.Pow(y, 2);
                Console.WriteLine("a^2+b^2 = " + z);
            }
    }
}
