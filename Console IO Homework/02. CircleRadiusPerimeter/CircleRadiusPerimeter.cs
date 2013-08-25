using System;

class CircleRadiusPerimeter
    {
        static void Main()
        {
            Console.WriteLine("Enter radius r of the circle:");
            double r = double.Parse(Console.ReadLine());

            double circlePerimeter = 2 * Math.PI * r;
            double circleArea = Math.PI * Math.Sqrt(r);

            Console.WriteLine("The perimeter of the circle is {0}. Its Area is {1}", circlePerimeter, circleArea);

        }
    }
