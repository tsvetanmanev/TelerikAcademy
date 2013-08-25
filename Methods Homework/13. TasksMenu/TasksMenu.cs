//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//        Create appropriate methods.
//        Provide a simple text-based menu for the user to choose which task to solve.
//        Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0


using System;

class TasksMenu
{
    static void ReverseNumber()
    {
        Console.WriteLine("Please enter a positive decimal number to reverse");

        string strNum = Console.ReadLine();

        decimal number = decimal.Parse(strNum);
        
        if (number<0)
        {
            Console.WriteLine("The decimal number should be non-negative");
            return;
        }

        char[] reversedArr = strNum.ToCharArray();
        Array.Reverse(reversedArr);

        string reversedStr = new string(reversedArr);

        decimal reversedNum = decimal.Parse(reversedStr);

        Console.WriteLine(reversedNum);
    }

    static void GetAverage()
    {
        Console.WriteLine("Enter the length of the sequence");

        int length = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the integers each on a separate line");

        int[] numArr = new int[length];
        int sum = 0;

        for (int i = 0; i < length; i++)
        {
            numArr[i] = int.Parse(Console.ReadLine());
            sum += numArr[i];
        }

        Console.WriteLine("The average of this sequence is: ");
        Console.WriteLine((sum/length));
    }

    static void SolveEquation()
    {
        Console.WriteLine("We have the following equation: \n a*x + b = 0");

        Console.WriteLine("Enter integer A  (A should not be zero) :");
        decimal a = decimal
            .Parse(Console.ReadLine());

        if (a == 0)
        {
            Console.WriteLine("A is zero");
            return;
        }

        Console.WriteLine("Enter integer B");
        decimal b = decimal.Parse(Console.ReadLine());

        decimal result = (-b) / a;

        Console.WriteLine("The result is (-{0})/ {1} = {2}", b, a, result);


    }


    static void Main()
    {
        Console.WriteLine("Please choose menu option:");
        Console.WriteLine("1. Reverse number   2. Calculate average   3.Solve equation");

        int input = int.Parse(Console.ReadLine());

        if (input == 1)
        {
            ReverseNumber();
        }

        else if (input == 2)
        {
            GetAverage();
        }

        else if (input == 3)
        {
            SolveEquation();
        }

        else
        {
            Console.WriteLine("Invalid input data");
        }
    }
}