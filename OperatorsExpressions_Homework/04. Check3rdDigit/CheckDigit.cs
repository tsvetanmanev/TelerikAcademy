using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CheckDigit
    {
        static void Main()
        {
            Console.WriteLine("Input number");
            string number = Console.ReadLine();
            char seven = '7';
            int stringLength = number.Length;

            if (number[stringLength - 3] == seven)
            {
                Console.WriteLine("True");
            }

            else
            {
                Console.WriteLine("False");
            }
        }
    }
