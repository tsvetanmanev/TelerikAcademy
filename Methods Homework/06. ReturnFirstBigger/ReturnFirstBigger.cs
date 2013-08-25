//Write a method that returns the index of the first 
//element in array that is bigger than its neighbors, 
//or -1, if there’s no such element.
//Use the method from the previous exercise.

using System;

class ReturnFirstBigger
{
    static int FirstBigger(int[] numArr)
    {
        int biggerIndx = -1;

        for (int i = 0; i < numArr.Length; i++)
        {
            if (BiggerCheck(numArr, i) == 1)
            {
                biggerIndx = i;
                break;
            }
        }

        return biggerIndx;
    }

    static int BiggerCheck(int[] numArr, int index)
    {
        int check = 0;

        if (index > 0 && index < numArr.Length - 1)
        {
            if (numArr[index] > numArr[index - 1] && numArr[index] > numArr[index + 1])
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
        int[] numArr2 = new int[11] { 9, 3, 4, 5, 6, 8, 10, 9, 1, 2, 4 };

        Console.WriteLine("We have the following arrays: ");

        PrintArray(numArr);

        int firstBiggerElement = FirstBigger(numArr);

        Console.WriteLine("The first element that is bigger then its neighbours is at index "+firstBiggerElement);
    }
}

