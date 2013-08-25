//Write a program that sorts an array of strings 
//using the quicksort algorithm (find it in Wikipedia)

using System;

class SieveOfPrimes
{
    static void Main()
    {
        long n = 10000000;

        bool[] numbersRange = new bool[n];

        for (int i = 0; i < n; i++)
        {
            numbersRange[i] = true;
        }

        for (long i = 2; i < n; i++)
        {
            if (numbersRange[i] == true)
            {
                for (long m = 0, j = i * i; j < n; m++, j = i * i + m * i)
                {
                    numbersRange[(int)j] = false;
                }
            }
        }

        for (int i = 2; i < n; i++)
        {
            if (numbersRange[i])
            {
                Console.WriteLine("{0} => {1}", i, numbersRange[i]);
            }
        }
    }
}
