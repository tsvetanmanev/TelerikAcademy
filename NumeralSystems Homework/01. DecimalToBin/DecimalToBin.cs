//Write a program to convert decimal numbers to their binary representation.

using System.Collections.Generic;
using System;

class DecimalToBin
{
    private static List<int> BinaryConvert(int input)
    {
        List<int> outList = new List<int>();
        int temp = input;
        int remainder;

        while (temp > 0)
        {
            int result = temp / 2;
            remainder = temp % 2;
            temp = result;
            outList.Add(remainder);

        }

        outList.Reverse();
        return outList;

    }


    private static void PrintBin(List<int> outList)
    {
        Console.WriteLine("Same number in binary is:");
        foreach (int number in outList)
        {
            Console.Write(number);
        }
        Console.WriteLine();
    }


    static void Main()
    {
        Console.WriteLine("Enter a decimal number:");

        int input = int.Parse(Console.ReadLine());

        List<int> outList = new List<int>();

        outList = BinaryConvert(input);

        PrintBin(outList);

    }

}
