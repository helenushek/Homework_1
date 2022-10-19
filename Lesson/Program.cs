using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
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


            double result = (5 * a + b * b) / (b - a);

            Console.WriteLine("Результат выражения = " + result);










        }
    }
}
