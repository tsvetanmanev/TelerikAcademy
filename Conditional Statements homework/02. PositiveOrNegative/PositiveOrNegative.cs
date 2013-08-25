using System;

class PositiveOrNegative
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            if (num1 < 0 ^ num2 < 0 ^ num3 < 0)
            {
                Console.WriteLine("The sigh of the product is -");
            }

            else
            {
                Console.WriteLine("The sigh of the product is +");
            }

        }
    }
