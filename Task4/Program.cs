using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.WriteLine("Введите число А");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите число B");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите число C");
            c = Convert.ToDouble(Console.ReadLine());

            double result = (b - c) / a;
            Console.WriteLine("Корень уравнения равен = " + result);


        }
    }
}
