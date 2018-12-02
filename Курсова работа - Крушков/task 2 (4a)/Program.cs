using System;

namespace таск_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въдеди а");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Въдеди b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Въдеди c");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Въдеди x");
            double x = double.Parse(Console.ReadLine());



            double f = ((b - a) / (2 * b + c)) * (a - c) * Math.Cos(x);
            Console.WriteLine($"Стойноста на израза е {f}");
        }
    }
}
