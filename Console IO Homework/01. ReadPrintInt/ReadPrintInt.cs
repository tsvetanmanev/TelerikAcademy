using System;

class ReadPrintInt
    {
        static void Main()
        {
            Console.WriteLine("Please enter integer 1: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter integer 2: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter integer 3: ");
            int n3 = int.Parse(Console.ReadLine());

            Console.WriteLine("The sum of {0} + {1} + {2} is {3}", n1,n2,n3, n1+n2+n3);
        }
    }
