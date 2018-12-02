
using System;

namespace task_410
{
   public class Program

{
      public static int[] readArray(int n)
    {
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        return array;
       }

    public static int getMax(int[] array)
    {
        int max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }

        return max;
    }

    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = readArray(n);
        int[] b = readArray(n);
        int[] c = readArray(n);

        int aMax = getMax(a);
        int bMax = getMax(b);
        int cMax = getMax(c);

        Console.WriteLine(aMax + "\n" + bMax + "\n" + cMax + "\n\n");

        Console.WriteLine(aMax * bMax * cMax);

        for (int i = 0; i < c.Length; i++)
        {
            c[i] = i % 2 == 1 ? a[i] + b[b.Length - i - 1] : a[i] - b[b.Length - i - 1];
        }
      }
    }
}

