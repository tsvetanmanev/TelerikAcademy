using System;

class PrintRoots
{
    static void Main()
    {
        Console.WriteLine("Please enter coefficient a: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter coefficient b: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter coefficient c: ");
        int c = int.Parse(Console.ReadLine());


        if (a == 0)
        {
            Console.WriteLine("Coafficient a cannot be zero");
            return;
        }

        else
        {
            int d = (b * b) - 4 * a * c;

            if (d < 0)
            {
                Console.WriteLine("The quadratic equation has no real roots");

            }

            else if (d == 0)
            {
                double x = (-b) / (2 * a);
                Console.WriteLine("The root x is " + x);
            }

            else
            {
                double x1 = ((-b) + Math.Sqrt(d)) / (2 * a);
                double x2 = ((-b) - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("The roots of the quadratic equations are 2: {0} and {1}", x1, x2);
            }


        }
    }
}
