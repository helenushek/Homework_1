using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
     class Program
    {
        static void Main(string[] args)
        {
            double a, b;

            Console.WriteLine("Введите число А");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите число B");
            b = Convert.ToDouble(Console.ReadLine());

            (a, b) = (b, a);
            Console.WriteLine("Теперь число A = " + a);

            Console.WriteLine("Теперь число B = " + b);
        }
    }
}
