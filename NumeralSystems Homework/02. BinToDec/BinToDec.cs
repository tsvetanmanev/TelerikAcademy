//Write a program to convert binary numbers to their decimal representation.


using System;
using System.Collections.Generic;

class BinToDec
{
    static void Main()
    {
        Console.WriteLine("Enter a binary number:");

        string binNum = Console.ReadLine();

        char[] inputArr = binNum.ToCharArray();

        Array.Reverse(inputArr);

        int sum = 0;

        for (int i = 0; i < inputArr.Length; i++)
        {
            int currentNum = int.Parse(inputArr[i].ToString());
            sum += currentNum * (int)Math.Pow(2,i);
        }
        Console.WriteLine("The decimal representation is:");
        Console.WriteLine(sum);
    }
}
