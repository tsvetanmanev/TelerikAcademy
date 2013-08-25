using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CompareFloatNumbers
{
    class CompareFloatingPoint
    {
        static void Main(string[] args)
        {
            Console.Write("First number: ");
            double firstNumber = Double.Parse(Console.ReadLine());

            Console.Write("Second number: ");
            double secondNumber = Double.Parse(Console.ReadLine());

            double substraction = Math.Abs(firstNumber - secondNumber);

            Console.WriteLine(substraction < 0.000001 ? "True" : "False");
        }
    }
}
