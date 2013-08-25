//You are given an array of strings. 
//Write a method that sorts the array by the length of its elements 
//(the number of characters composing them).

using System;
using System.Linq;

class SortByLength
{
    public static int LengthCompare(string x, string y)
    {
        int retval = x.Length.CompareTo(y.Length);
        if (retval != 0)
        {
            // If the strings are not of equal length, 
            // the longer string is greater.

            return retval;
        }
        else
        {
            // If the strings are of equal length, 
            // sort them with ordinary string comparison.
            return x.CompareTo(y);
        }

    }

    private static void PrintArray(string[] strArr)
    {
        foreach (string word in strArr)
        {
            Console.Write("{0}, ", word);
        }
        Console.WriteLine();

    }

    static void Main()
    {
        string[] strArr = new string[] 
        { "apple", "computer", "pear", "bed", "mountain", "breakfast", "rain", "happiness" };

        Console.WriteLine("The unsorted array is: ");
        PrintArray(strArr);
        Console.WriteLine();

        
        Array.Sort(strArr, LengthCompare);

        Console.WriteLine("The sorted array is: ");
        PrintArray(strArr);
    
    }

    
}
