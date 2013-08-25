using System;

class GetNReads
    {
        static void Main()
        {
            Console.WriteLine("Enter number N:");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter next number");
                int m = int.Parse(Console.ReadLine());
                sum += m;
            }

            Console.WriteLine("The sum of all the numbers is "+sum);
        }
    }