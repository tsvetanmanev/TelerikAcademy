using System;

class ProductFactorials
    {
        static void Main()
        {
            Console.WriteLine("Enter number N, (N>1):");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number K, (K>N):");
            int k = int.Parse(Console.ReadLine());

            int divider = k - n;
            double sumDivider = 1;
            double sumN = 1;
            double sumK = 1;

            if ((n > 1) && (k > n))
            {
                for (int i = 1; i < n; i++)
                {
                    sumN *= i;
                }

                for (int i = 1; i < k; i++)
                {
                    sumK *= i;
                }

                for (int i = 1; i < divider; i++)
                {
                    sumDivider *= i;
                }
                double product = (sumN * sumK)/sumDivider;

                Console.WriteLine("The product of N!*K! / (K-N)! is  "+ product);
            }

            else
            {
                Console.WriteLine("Wrong input");
            }
        }
    }
