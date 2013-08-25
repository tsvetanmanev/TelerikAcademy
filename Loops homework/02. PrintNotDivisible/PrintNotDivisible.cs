using System;

class PrintNotDivisible
    {
        static void Main()
        {
            Console.WriteLine("Please enter integer number N");
            int n = int.Parse(Console.ReadLine());
            int number = 1;

            while (number <= n)
            {
                if (!((number % 3 == 0) && (number % 7 == 0)))
                {
                    Console.WriteLine(number);
                }
                number++;
            }
        }
    }