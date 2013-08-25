using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.StringHelloWorld
{
    class StringHelloWorld
    {
        static void Main(string[] args)
        {
            string word1 = "Hello";
            string word2 = "World";
            object greeting = hello + ", " + world + "!";
            string fullGreeting = (string)greeting;
            Console.WriteLine(fullGreeting);
        }
    }
}
