using System;

    class CatalanNum
    {
        static void Main()
        {
            //Catalan number = (2*n)! / (n+1)! * n!

            Console.WriteLine("Input integer n: ");
            int n = int.Parse(Console.ReadLine());
            decimal sum1 = 1;
            decimal sum2 = 1;
            decimal sum3 = 1;

            for (int i = 1; i < (2*n); i++)
            {
                sum1 *= i;
            }

            for (int i = 1; i < (n+1); i++)
            {
                sum2 *= i;
            }

            for (int i = 1; i < n; i++)
            {
                sum3 *= i;
            }

            decimal catSum = sum1 / sum2 * sum3;

            Console.WriteLine("The product of the Catalan formula (2*n)! / (n+1)! * n! is : "+catSum);
        }
    }
