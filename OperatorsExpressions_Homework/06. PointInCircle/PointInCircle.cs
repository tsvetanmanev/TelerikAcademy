using System;

class PointInCircle
    {
        static void Main()
        {
            double radius = 5;
            Console.WriteLine("The radius of the circle is 5 and its center is 0");
            Console.WriteLine("Please input height:");
            double h = Double.Parse(Console.ReadLine());

            Console.WriteLine("Please input width:");
            double w = Double.Parse(Console.ReadLine());

            double distance = Math.Sqrt(h * h + w * w);

            if (distance > radius)
            {
                Console.WriteLine("The point is outside of the circle");
            }

            else
            {
                Console.WriteLine("The point is inside of the circle");
            }

        }
    }