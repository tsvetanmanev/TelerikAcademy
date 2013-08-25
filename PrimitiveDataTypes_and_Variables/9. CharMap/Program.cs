using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.CharMap
{
    class CharMap
    {
        static void Main(string[] args)
        {
            char copyCaracter = '\u00A9';

            for (int verticalCount = 0; verticalCount < 3; verticalCount++)
                {
                    for (int horizontalCount = 1; horizontalCount < 6; horizontalCount++)
                    {
                        Console.Write("{0}", Math.Abs(3 - horizontalCount) > verticalCount ? ' ' : copyCaracter);
                    }
                Console.WriteLine();
                }
        }
    }
}
