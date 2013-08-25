using System;

static class OddOrEvenCheck
    {
        static void Main()
        {
            Console.WriteLine("Input number:");
            int n = Int32.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }

            else
            {
                Console.WriteLine("The number is odd");
            }
        }
    }
