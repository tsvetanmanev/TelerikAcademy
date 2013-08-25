//You are given a sequence of positive 
//integer values written into a string, separated by spaces. 
//Write a function that reads these values from given string 
//and calculates their sum. Example:
//        string = "43 68 9 23 318"  result = 461


using System;

class SumIntsFromString
{
    private static int ReadAndSum(string input)
    {
        int sum = 0;

        string[] numbers = input.Split(' ');

        foreach (string number in numbers)
        {
            int num = int.Parse(number);
            sum += num;
        }

        return sum;

    }

    static void Main()
    {
        Console.WriteLine("Please enter several integers on a single line separated by blank spaces:");

        string input = Console.ReadLine();

        int sum = ReadAndSum(input);

        Console.WriteLine("The sum of the integers is: " + sum);
    }


}
