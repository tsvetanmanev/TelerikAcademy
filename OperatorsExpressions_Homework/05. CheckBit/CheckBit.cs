using System;

 class CheckBit
    {
        static void Main()
        {
            Console.WriteLine("Input number:");
            int n = Int32.Parse(Console.ReadLine());

            int p = 3;

            int mask = 1 << p;
            int nAndMask = n & mask;
            int bit = nAndMask >> p;

            Console.WriteLine("The number in bit position {0} is {1}", p, bit);

        }
    }
