using System;

class DivFactorials
    {
        static void Main()
        {
            Console.WriteLine("Enter number N, (N>1):");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number K, (K<N):");
            int k = int.Parse(Console.ReadLine());

            decimal sumN = 1;
            decimal sumK = 1;
            

            if ((1 < k) && (k < n))
            {
                for (int i = 1; i < n; i++)
                {
                    sumN *= i;
                }

                for (int i = 1; i < k; i++)
                {
                    sumK = sumK*i;
                }

                decimal product = sumN / sumK;

                Console.WriteLine("The product of N!/K! is " + product);
            }

            else
            {
                Console.WriteLine("Wrong input");
            }
        }
    }
