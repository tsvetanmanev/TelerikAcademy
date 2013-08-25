//Write a program to calculate n! for each n in the range [1..100].
//Hint: Implement first a method that multiplies a number 
//represented as array of digits by given integer number. 


using System;
using System.Numerics;

class CalcFactorial
{
    public static BigInteger CalculateFactorial(int[] array, int index)
    {
        BigInteger factorial = 1;
        for (int i = 1; i <= index; i++)
        {
            factorial *= array[i];
        }

        return factorial;
    }

    static void Main()
    {
        int[] hundredArr = new int[100];

        for (int i = 0; i < 100; i++)
        {
            hundredArr[i] = i;
        }

        foreach (int index in hundredArr)
        {
            Console.WriteLine(CalculateFactorial(hundredArr, index));
        }
    }
}