//Write a program that reads a year from the console 
//and checks whether it is a leap. Use DateTime.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LeapYearCheck
{
    static void Main()
    {
        Console.WriteLine("Please input year:");

        int inputYear = int.Parse(Console.ReadLine());

        if (DateTime.IsLeapYear(inputYear))
        {
            Console.WriteLine(inputYear + " is a leap year.");
        }

        else
        {
            Console.WriteLine(inputYear + " is NOT a leap year.");
        }


    }
}