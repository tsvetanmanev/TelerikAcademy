using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.SwapIntegers
{
    class SwapIntegers
    {
        static void Main(string[] args)
        {
            int number1 = 5;
            int number2 = 10;

            Console.WriteLine("The variable A is {0} and the variable B is {1}\n", number1, number2);

            int number3 = number1;
            number1 = number2;
            number2 = number3;

            Console.WriteLine("Now the variable A is {0} and the variable B is {1}\n", number1, number2);
        }
    }
}
