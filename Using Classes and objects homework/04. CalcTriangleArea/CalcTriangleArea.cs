//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it; Three sides; 
//Two sides and an angle between them. 
//Use System.Math.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CalcTriangleArea
{
    static void Main()
    {
        Console.WriteLine("Please enter a triangle side:");
        double triaSideA = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter its altitude:");
        double triaHeight = double.Parse(Console.ReadLine());

        double surface = AreaFromSideAlt(triaSideA, triaHeight);
        Console.WriteLine("The area of this triangle is " + surface);
        Console.WriteLine();


        Console.WriteLine("Please enter the 3 sides of a triangle, each on a separate line");
        triaSideA = double.Parse(Console.ReadLine());
        double triaSideB = double.Parse(Console.ReadLine());
        double triaSideC = double.Parse(Console.ReadLine());

        double surface2 = AreaFromSides(triaSideA, triaSideB, triaSideC);
        Console.WriteLine("The area of this triangle is " + surface2);
        Console.WriteLine();

        Console.WriteLine("Please enter the 2 sides of a triangle each on a separate line");
        triaSideA = double.Parse(Console.ReadLine());
        triaSideB = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the angle between these 2 sides (in degrees):");
        double angle = double.Parse(Console.ReadLine());

        double surface3 = AreaFromSidesAngle(triaSideA, triaSideB, angle);
        Console.WriteLine("The area of this triangle is " + surface3);
        Console.WriteLine();

    }

    private static double AreaFromSidesAngle(double triaSideA, double triaSideB, double angle)
    {
        double result = (triaSideA * triaSideB * Math.Sin(angle*(Math.PI/180))/2);
        return result;
    }

    private static double AreaFromSides(double a, double b, double c)
    {
        double p = (a + b + c) / 2;
        double result = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        return result;
    }

    private static double AreaFromSideAlt(double triaSide, double triaHeight)
    {
        double result = (triaSide * triaHeight) / 2;
        return result;
    }


}
