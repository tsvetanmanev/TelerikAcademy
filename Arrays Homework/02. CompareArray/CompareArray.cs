using System;

class CompareArray
    {
        static void Main()
        {
            Console.WriteLine("Enter length n of the two arrays: ");
            int n = int.Parse(Console.ReadLine());

            int[] firstArr = new int[n];
            int[] secondArr = new int[n];

            Console.WriteLine("Enter integer in the first array on a separate line");
            for (int i = 0; i < n; i++)
            {
                firstArr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter integer in the second array on a separate line");
            for (int i = 0; i < n; i++)
            {
                secondArr[i] = int.Parse(Console.ReadLine());
            }

            bool isEqual = true;
            bool firstLarger = false;
            bool secondLarger = false;

            for (int i = 0; i < n; i++)
            {
                if (firstArr[i] > secondArr[i])
                {
                    firstLarger = true;
                    isEqual = false;
                    break;
                }

                else if (firstArr[i] < secondArr[i])
                {
                    secondLarger = true;
                    isEqual = false;
                    break;
                }
            }

            if (isEqual)
            {
                Console.WriteLine("The arrays are equal");
            }

            else if (firstLarger)
            {
                Console.WriteLine("The first array is larger");
            }

            else if (secondLarger)
            {
                Console.WriteLine("The second array is larger");
            }

        }
    }
