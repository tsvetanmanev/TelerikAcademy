﻿using System;

class MaximalIncreasingSequence
{
    static void Main()
    {
        int[] myArray = { 3, 2, 3, 4, 5, 2, 2, 3, 4, 5, 6 };
        int len = 1;
        int bestLen = 0;
        int endIndex = 0;
        // main logic
        for (int i = 0; i < myArray.Length - 1; i++)
        {
            if (myArray[i] < myArray[i + 1])
            {
                len++;
            }
            else
            {
                if (len > bestLen)
                {
                    bestLen = len;
                    endIndex = i;
                }
                len = 1;
            }
        }
        // checking a special last case
        if (len > bestLen)
        {
            bestLen = len;
            endIndex = myArray.Length - 1;
        }
        // output
        len = 1;
        Console.WriteLine("The longest sequence of increasing elemints is:");
        Console.Write("{");
        for (int i = endIndex - bestLen + 1; i < endIndex + 1; i++)
        {
            Console.Write("{0},", myArray[i]);
        }
        Console.WriteLine("}");
    }
}