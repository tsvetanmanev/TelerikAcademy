using System;

class PointInArea
{
    static void Main()
    {
        double radius = 3;
        
        Console.WriteLine("Please input x:");
        double x = Double.Parse(Console.ReadLine());

        Console.WriteLine("Please input y:");
        double x = Double.Parse(Console.ReadLine());

        double distance = Math.Sqrt((x + 1) * (x + 1) + (y + 1) * (y + 1));

        if (((x + 1) * (x + 1) + (y + 1) * (y + 1)) <= radius) && true )
        {
            Console.WriteLine("The point is outside of the circle");
        }

        else
        {
            Console.WriteLine("The point is inside of the circle");
        }

    }
}