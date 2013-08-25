using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.PrintASCII
{
    class PrintASCII
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            for (int symbol = 0; symbol < 255; symbol++)
            {
                Console.WriteLine((char)symbol);
            }
        }
    }
}
