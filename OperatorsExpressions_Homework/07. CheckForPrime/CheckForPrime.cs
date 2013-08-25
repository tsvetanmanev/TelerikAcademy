using System;

class CheckForPrime
    {
        static void Main()
        {
            Console.WriteLine("Please input positive interger number lower than 101:");
            int n = Int32.Parse(Console.ReadLine());

            for (int i = 2; i < 50; i++)
            {
                if (n % i == 0 && n != i)
                {
                    Console.WriteLine("The number is not prime");
                    break;
                }

                else
                {
                    Console.WriteLine("The number is prime");
                    break;
                }
                
            }
        }
    }
