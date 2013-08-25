using System;
using System.Numerics;


class FibonacciSeq
    {
        static void Main()
        {
            BigInteger a = 0;
            BigInteger b = 1;

            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(a);
                BigInteger temp = a;
                a = b;
                b = temp + b;
                
            }
        }
    }
