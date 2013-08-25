using System;
using System.Numerics;

class FibonacciSum
    {
        static void Main()
        {
            Console.WriteLine("Enter integer number n:");
            int n = int.Parse(Console.ReadLine());
            BigInteger a = 0;
            BigInteger b = 1;
            BigInteger sum = 0;
            


            for (int i = 0; i <= n; i++)
            {
                sum += a;
                Console.WriteLine(a);
                BigInteger temp = a;
                a = b;
                b = temp + b;
                
            }
            Console.WriteLine();
            Console.WriteLine("The sum of the first N members of Fibonacci sequence are: "+sum);
        }
    }
