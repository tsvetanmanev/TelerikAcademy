//Write a method that asks the user for his name 
//and prints “Hello, <name>” (for example, “Hello, Peter!”). 
//Write a program to test this method.


using System;

class HelloName
{
    static void PrintName(string name)
    {
        Console.WriteLine("Hello, {0}!", name);
    }

    static void Main()
    {
        Console.WriteLine("Please enter your first name:");
        string name = Console.ReadLine();

        PrintName(name);
    }
}