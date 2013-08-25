using System;

class PrintInterval
    {
        static void Main()
        {
            Console.WriteLine("Enter number N:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
