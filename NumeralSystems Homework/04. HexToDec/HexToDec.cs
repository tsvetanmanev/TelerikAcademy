//Write a program to convert hexadecimal numbers to their decimal representation.


using System;
using System.Collections.Generic;

class HexToDec
{
    private static int DecConvert(char[] inputHex)
    {
        char[] hexCodeArr = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        int sum = 0;

        Array.Reverse(inputHex);

        for (int i = 0; i < inputHex.Length; i++)
        {
            for (int j = 0; j < hexCodeArr.Length; j++)
			{
			     if (inputHex[i] == hexCodeArr[j])
                {
                    sum += j * (int)Math.Pow(16, i); 
                }
			}
            
        }

        return sum;
    }

    static void Main()
    {
        Console.WriteLine("Enter Hexademical number");
        char[] inputHex = Console.ReadLine().ToCharArray();

        int decNum = DecConvert(inputHex);

        Console.WriteLine(decNum);
    }

}
