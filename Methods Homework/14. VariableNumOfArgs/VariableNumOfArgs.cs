//Write methods to calculate minimum, maximum, average, 
//sum and product of given set of integer numbers. 
//Use variable number of arguments.


using System;

class VariableNumOfArgs
{
    static long CalcSum(params int[] elements)
    {
        long sum = 0;
        foreach (int element in elements)
        {
            sum += element;
        }
        return sum;
    }

    static int GetMin(params int[] elements)
    {
        int min = int.MaxValue;

        for (int i = 0; i < elements.Length; i++)
        {
            if (elements[i] < min)
            {
                min = elements[i];
            }
        }

        return min;
    }

    static int GetMax(params int[] elements)
    {
        int min = int.MinValue;

        for (int i = 0; i < elements.Length; i++)
        {
            if (elements[i] > min)
            {
                min = elements[i];
            }
        }

        return min;
    }

    static double GetAverage(params int[] elements)
    {
        int sum = 0;

        foreach (int element in elements)
        {
            sum += element;
        }

        double average = sum / elements.Length;

        return average;
    }

    static void Main()
    {
        Console.WriteLine(CalcSum(2, 5, -2, 12));
        Console.WriteLine(GetMin(2, 5, -2, 12));
        Console.WriteLine(GetMax(2, 5, -2, 12));
        Console.WriteLine(GetAverage(1,2,4,5,6));
        
    }
}
