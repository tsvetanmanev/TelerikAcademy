//Write a method that counts how many times given 
//number appears in given array. Write a test program 
//to check if the method is working correctly.


using System;

class RepetitionTimes
{
    private static void PrintArray(int[] numArr)
    {
        foreach (int num in numArr)
        {
            Console.Write("{0}, ", num);
        }
        Console.WriteLine();

    }

    static int RepeatsCount(int number, int[] numArr)
    {
        int counter = 0;

        for (int i = 0; i < numArr.Length; i++)
        {
            if (number == numArr[i])
            {
                counter++;
            }
        }

        return counter;
    }
    static void Main()
    {
        int[] numArr = new int[11] 
        { 1, 3, 4, 5, 4, 209, 2, 31, 1, 2, 4 };

        Console.WriteLine("We have the following array: ");

        PrintArray(numArr);

        Console.WriteLine("Please enter number to search for repetitions: ");
        int number = int.Parse(Console.ReadLine());

        int repeats = RepeatsCount(number, numArr);

        Console.WriteLine("This number is repeated {0} times in the array", repeats);
    }
}
