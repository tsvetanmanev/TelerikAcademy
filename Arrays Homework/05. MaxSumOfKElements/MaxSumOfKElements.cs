// Write a program that reads two integer numbers N
//and K and an array of N elements from the console.
// Find in the array those K elements that have maximal sum.

using System;

class MaxSumOfKElements
    {
        static void Main()
        {
            Console.WriteLine("Enter integer N:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter integer K:");
            int k = int.Parse(Console.ReadLine());



            int[] myArr = new int[n];

            Console.WriteLine("Enter the elements of the array:");

            for (int i = 0; i < n; i++)
            {
                myArr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(myArr);

            Console.WriteLine("The {0} elements that have maximal sum are: ", k);

            for (int i = myArr.Length - 1; i >= myArr.Length-k; i--)
            {
                Console.WriteLine(myArr[i]);
            }
        }
    }