using System;

namespace task_102
{
    class Program
    {
        static void Main(string[] args)
        {
            int luckyTicketsCount = 0;
            int unluckyTicketsCount = 0;

            for (int i = 0; i < 1000000; i++)
            {
                if ((i / 100000 + i / 10000 % 10 + i / 1000 % 10) == (i / 100 % 10 + i / 10 % 10 + i % 10))
                {
                    //Console.WriteLine(i); //spam
                    luckyTicketsCount++;
                }
                else
                {
                    unluckyTicketsCount++;
                }
            }

            Console.WriteLine("The number of lucky tickets is: " + luckyTicketsCount);
            Console.WriteLine("The number of unlucky tickets is: " + unluckyTicketsCount);
            Console.WriteLine($"Total tickets: {luckyTicketsCount + unluckyTicketsCount}");
        }
    }
}
