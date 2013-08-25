//Write a method GetMax() with two parameters that 
//returns the bigger of two integers. Write a program 
//that reads 3 integers from the console and prints 
//the biggest of them using the method GetMax().


using System;

class GetMaxNum
{
    static int GetMax(int first, int second)
    {
        if (first>second)
        {
            return first;
        }
        else
        {
            return second;
        }
    }

    static void Main()
    {
        Console.WriteLine("Please enter first integer:");
        int firstNum = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter second integer:");
        int secondNum = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter third integer:");
        int thirdNum = int.Parse(Console.ReadLine());

        int max = GetMax(firstNum, secondNum);

        max = GetMax(max, thirdNum);

        Console.WriteLine("The maximum number is " +max);
    }
}
