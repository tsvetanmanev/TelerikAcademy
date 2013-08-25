using System;

class DivByFive
    {
        static void Main()
        {
            Console.WriteLine("Enter first positive integer:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second positive integer:");
            int m = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = n; i <= m; i++)
            {
                if (i%5==0)
                {
                    counter++;
                }

                else
                {
                    continue;
                }
            }

            Console.WriteLine("There are {0} p numbers", counter);
        }
    }
