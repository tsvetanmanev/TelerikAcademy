using System;

class PrintGreaterNum
    {
        static void Main()
        {
            Console.WriteLine("Please first number: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please second number: ");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("The greater number is " + Math.Max(n,m));
        }
    }
