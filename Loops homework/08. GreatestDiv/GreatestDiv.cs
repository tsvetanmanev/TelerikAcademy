using System;


class GreatestDiv
    {
        static void Main()
        {
            Console.WriteLine("Enter first integer number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second integer number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            int GCD = 0;
            int a = 0;

            if (firstNumber>secondNumber)
                {
                    a = secondNumber;
                    secondNumber = firstNumber;
                    firstNumber = a;
                }

            while (secondNumber != 0)
            {
                GCD = firstNumber % secondNumber;
                firstNumber = secondNumber;

                if (GCD == 0)
                {
                    GCD = secondNumber;
                    break;
                }

                else
                {
                    secondNumber = GCD;
                }
                
            }

            Console.WriteLine("The GCD is "+GCD);

        }
    }
