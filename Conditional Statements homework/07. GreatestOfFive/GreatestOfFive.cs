using System;
using System.Linq;

class GreatestOfFive
    {
        static void Main()
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());
            int n5 = int.Parse(Console.ReadLine());

            int[] numbers = { n1, n2, n3, n4, n5 };

            int biggestNum = numbers.Max();

            Console.WriteLine(biggestNum);
        }
    }