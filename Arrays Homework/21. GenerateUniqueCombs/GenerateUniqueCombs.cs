﻿//21. write a program that reads two numbers n and k
//and generates all the combinations of k distinct 
//elements from the set [1..n]. example:
//n = 5, k = 2 ‡ {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 
//4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}
//
//Code credits to nzhul on telerikacademy forums and github/nzhul

using System;

class GenerateUniqueCombs
{
    static int n = int.Parse(Console.ReadLine());
    static int k = int.Parse(Console.ReadLine());

    //generates variations
    static void Combinations(int[] array, int index, int currentNumber)
    {
        if (index == array.Length)
        {
            PrintArray(array);
        }
        else
        {
            for (int i = currentNumber; i <= n; i++)
            {
                array[index] = i;
                Combinations(array, index + 1, i + 1);
            }
        }
    }

    //prints array
    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int[] array = new int[k];
        Combinations(array, 0, 1);
    }
}
