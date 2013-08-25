//Write a method that return the maximal element in a portion of array of integers 
//starting at given index. 
//Using it write another method that sorts an array in ascending / descending order.


using System;
using System.Linq;

class MaxElementSort
{
    private static int[] DescendSort(int[] numArr)
    {
        int[] reversed = AscendSort(numArr);

        reversed = reversed.Reverse().ToArray();

        return reversed;

        
    }
       
    private static int[] AscendSort(int[] numArr)
    {
        int maxElementIndex = 0;

        for (int i = 0; i < numArr.Length; i++)
        {

            maxElementIndex = FindMax(numArr, i);
            int swap = numArr[maxElementIndex];
            numArr[maxElementIndex] = numArr[i];
            numArr[i] = swap;
        }

        return numArr;
    }


    private static int FindMax(int[] numArr, int start)
    {
        int maxEl = start;

        for (int i = start + 1; i < numArr.Length; i++)
        {
            if (numArr[i] > numArr[maxEl])
            {
                maxEl = i;
            }
        }


        return maxEl;
    }
    
    static void PrintArray(int[] numArr)
    {
        foreach (int num in numArr)
        {
            Console.Write("{0}, ", num);
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int[] numArr = new int[11] { 1, 3, 5, 5, 6, 209, 7, 31, 25, 30, 15 };
        Console.WriteLine("We have the following arrays: ");

        PrintArray(numArr);

        Console.WriteLine("Enter index for the start of the search for maximal element: ");
        int start = int.Parse(Console.ReadLine());

        int maxIndex = FindMax(numArr, start);

        Console.WriteLine(numArr[maxIndex]);

        int[] sortedArr = AscendSort(numArr);

        int[] descentArr = DescendSort(numArr);

        PrintArray(sortedArr);

        PrintArray(descentArr);
    }

        
}
