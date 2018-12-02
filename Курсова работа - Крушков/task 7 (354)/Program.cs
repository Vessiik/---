using System;

namespace task_354
{
   
 class Program
{
    public static double Read(double x, double y)
    {
        Random random = new Random();
        double min = Math.Min(x, y);
        double max = Math.Max(x, y);
        return random.NextDouble() * (max - min) + min;
    }

    public static void Main()
    {
        Console.WriteLine(Read(5.5, 20.5));
    }
  }
}