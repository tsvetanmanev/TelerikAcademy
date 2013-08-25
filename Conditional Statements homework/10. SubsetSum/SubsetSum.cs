using System;

class SubsetSum
    {
        static void Main()
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());
            int n5 = int.Parse(Console.ReadLine());

            int counter = 0;

            int[] numbers = new int[]{n1, n2, n3, n4, 5};

            for (int i = 1; i < 32; i++)
            {
                int sum = 0;
                for (int j = 0; j < 5; j++)
                {
                    sum += ((i >> j) & 1) * numbers[j];
                }
                if (sum == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter + " Subset sums = 0"); 




        }
    }

