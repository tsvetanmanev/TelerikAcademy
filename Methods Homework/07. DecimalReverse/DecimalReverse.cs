//Write a method that reverses the digits of given decimal number. 
//Example: 256  652


using System;

class DecimalReverse
{
    private static decimal ReverseDecimal(string input)
    {
        decimal reversed = 0;

        char[] reversedArr = input.ToCharArray();
        Array.Reverse(reversedArr);

        string reversedStr = new string(reversedArr);

        Console.WriteLine(reversedStr);
        reversed = decimal.Parse(reversedStr);

        return reversed;
    }

    static void Main()
    {
        Console.WriteLine("Please enter a decimal number:");
        string input = Console.ReadLine();

        decimal reversed = ReverseDecimal(input);

        Console.WriteLine(reversed);
    }

}