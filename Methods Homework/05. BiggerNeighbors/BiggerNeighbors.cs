//Write a method that checks if the element at given 
//position in given array of integers is bigger than its 
//two neighbors (when such exist).


using System;

class BiggerNeighbors
{
    static int BiggerCheck(int[] numArr, int index)
    {
        int check = 0;
        
        if (index > 0 && index < numArr.Length-1)
        {
            if (numArr[index] > numArr[index-1] && numArr[index] > numArr[index+1])
            {
                check = 1;
            }

            else
            {
                check = 0;
            }
        }

        else
        {
            check = -1;
        }

        return check;
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
        int[] numArr = new int[11] { 1, 3, 4, 5, 4, 209, 2, 31, 1, 2, 4 };

        Console.WriteLine("We have the following array: ");

        PrintArray(numArr);

        Console.WriteLine("Enter the index of the element you want to check:");
        int index = int.Parse(Console.ReadLine());
        Console.WriteLine();

        int check = BiggerCheck(numArr, index);

        if (check > 0)
        {
            Console.WriteLine("The element is bigger that its two neighbors.");
        }

        else if (check == 0)
        {
            Console.WriteLine("The element is NOT bigger that its two neighbors.");
        }

        else if (check < 0)
        {
            Console.WriteLine("The element does not have two neighbours.");
        }
    }
}
