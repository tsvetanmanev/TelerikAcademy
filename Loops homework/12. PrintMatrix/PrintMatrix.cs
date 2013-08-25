using System;

class PrintMatrix
    {
        static void Main()
        {
            Console.WriteLine("Enter integer N (N<20): ");
            int n = int.Parse(Console.ReadLine());

            int number = 1;
            for (int column = 1; column <= n; column++)
            {
                number = column;
                for (int row = 1; row <= n; row++)
                {
                    Console.Write(number);
                    number++;
                }

                Console.WriteLine();
            }
        }
    }
