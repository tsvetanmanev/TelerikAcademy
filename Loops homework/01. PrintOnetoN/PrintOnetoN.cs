using System;

class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter integer number N");
            int n = int.Parse(Console.ReadLine());
            int number = 1;

            while(number<=n)
            {
                Console.WriteLine(number);
                number++;
            }
        }
    }
