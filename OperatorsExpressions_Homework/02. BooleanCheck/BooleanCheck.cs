using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BooleanCheck
    {
        static void Main()
        {
            Console.WriteLine("Input number:");
            int n = Int32.Parse(Console.ReadLine());

            if (n % 7 == 0 && n % 5 == 00)
            {
                Console.WriteLine("Number can be divided by 7 and 5 at the same time");
            }

            else
            {
                Console.WriteLine("Number cannot be divided by 7 and 5 at the same time");
            }
        }
    }
