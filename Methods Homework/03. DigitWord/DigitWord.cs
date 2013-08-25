//Write a method that returns the last digit
//of given integer as an English word. 
//Examples: 512  "two", 1024  "four", 12309  "nine".


using System;

class DigitWord
{
    static string LastDigitWord(string number)
    {
        switch (number[number.Length-1])
        {
            case '0':
                string word = "zero";
                return word;
            case '1':
                word = "one";
                return word;
            case '2':
                word = "two";
                return word;
            case '3':
                word = "three";
                return word;
            case '4':
                word = "four";
                return word;
            case '5':
                word = "five";
                return word;
            case '6':
                word = "six";
                return word;
            case '7':
                word = "seven";
                return word;
            case '8':
                word = "eight";
                return word;
            case '9':
                word = "nine";
                return word;
            default:
                word = "mistake";
                return word;
        }
    }

    static void Main()
    {
        Console.WriteLine("Please enter a integer: ");
        string number = Console.ReadLine();

        Console.WriteLine(LastDigitWord(number));
    }
}
