using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 class RectangleArea
    {
        static void Main()
        {
            Console.WriteLine("Please input height:");
            double height = Double.Parse(Console.ReadLine());
            Console.WriteLine("Please input width:");
            double width = Double.Parse(Console.ReadLine());

            double area = height * width;

            Console.WriteLine("The are of the rectangle is " + area);
        }
    }
