//Write a program to convert decimal numbers to their hexadecimal representation.


using System;
using System.Collections.Generic;

class DecToHex
{ 
    private static void PrintOutput(List<char> outList)
    {
        Console.WriteLine("Same number in hexademical is:");
        foreach (char number in outList)
        {
            Console.Write(number);
        }
        Console.WriteLine();
    }

    private static List<char> HexConvert(int input)
    {
        char[] hexCodeArr = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

        List<char> outList = new List<char>();
        int temp = input;
        int remainder;
        char newElement;
        while (temp > 0)
                {
                    int result = temp / 16;
                    remainder = temp % 16;

                    newElement = hexCodeArr[remainder];
            
                    outList.Add(newElement);
                    temp = result;
                }

                outList.Reverse();
                return outList;
    }

    static void Main()
    {
        Console.WriteLine("Enter a decimal number:");

        int input = int.Parse(Console.ReadLine());

        List<char> outList = new List<char>();

        outList = HexConvert(input);

        PrintOutput(outList);
    }



}
