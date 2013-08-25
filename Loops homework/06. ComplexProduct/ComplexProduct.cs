using System;

class ComplexProduct
    {
        static void Main()
        {
            Console.WriteLine("Please enter integer N");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter integer X");
            int x = int.Parse(Console.ReadLine());
            decimal sum = 1 + Decimal.Divide(1, x);
            decimal facSum = 1;

            for (int i = 2; i < n; i++)
            {
                facSum = 1;
                for (int j = 1; j < i; j++)
                {
                    facSum *= j;
                }

                decimal rooted = (decimal)(Math.Pow(x, i));
                sum += Decimal.Divide(facSum,rooted);
            }

            Console.WriteLine("The sum S of 1 + 1 + 1!/X + 2!/X^2 + ... + N!/X^N is " +sum);
        }
    }
