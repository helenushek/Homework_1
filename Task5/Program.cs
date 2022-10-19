using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, a, b;

            Console.WriteLine("Введите координату x1");
            x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координату x2");
            x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координату y1");
            y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координату y2");
            y2 = Convert.ToDouble(Console.ReadLine());

            a = (y1 - y2) / (x1 - x2);
            b = y2 - (a * x2);

            Console.WriteLine("Уравнение прямой проходящей через точки - у = " + a + " x + " + b);
        }
    }
}
