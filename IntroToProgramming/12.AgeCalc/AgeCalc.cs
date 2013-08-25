using System;

class AgeCalc
    {
        static void Main()
        {
            Console.WriteLine("Enter your age:");

            int ageNow = Int32.Parse(Console.ReadLine());

            int ageIn10Years = ageNow + 10;

            Console.WriteLine("Your age after 10 years will be " +ageIn10Years);
        }
    }
