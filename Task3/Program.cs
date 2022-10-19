using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;

            Console.WriteLine("Введите число А");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите число B");
            b = Convert.ToDouble(Console.ReadLine());

            double result = a / b;
            double result2 = a % b;

            Console.WriteLine("Частное двух чисел = " + result);
            Console.WriteLine("Остаток от деления =" + result2);
        }
    }
}
