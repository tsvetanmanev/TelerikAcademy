using System;


class TrapezoidArea
    {
        static void Main()
        {
            
            Console.WriteLine("Please input side a:");
            double a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Please input side b:");
            double b = Double.Parse(Console.ReadLine());
            Console.WriteLine("Please input height:");
            double height = Double.Parse(Console.ReadLine());

            double area = ((a + b) / 2) * height;
            Console.WriteLine("The are of the trapezoid is " + area);
        }
    }
