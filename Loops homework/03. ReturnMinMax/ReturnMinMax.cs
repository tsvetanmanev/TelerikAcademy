using System;

class ReturnMinMax
    {
        static void Main()
        {
            Console.WriteLine("How many numbers?");

            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter number");
                numbers[i] = int.Parse(Console.ReadLine());                                
            }

            int maxNum = 0;
            int minNum = numbers[0];

            for (int i = 0; i < n; i++)
            { 
                if (numbers[i] > maxNum)
                {
                    maxNum = numbers[i];
                }

                if (numbers[i] < minNum)
                {
                    minNum = numbers[i];
                }
            }


            Console.WriteLine("The maximal number is " + maxNum);
            Console.WriteLine("The minimal number is " + minNum);
        }
    }
