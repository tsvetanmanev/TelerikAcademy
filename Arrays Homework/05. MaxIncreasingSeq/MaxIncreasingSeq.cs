using System;

class MaxIncreasingSeq
    {
        static void Main()
        {
            int[] array = new int[] { 3, 2, 3, 4, 5, 2, 2, 3, 4, 7};

            int counter = 1;
            int maxCounter = 0;

            int lastIndex = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] < array[i + 1])
                {
                    counter++;
                }

                else
                {
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        lastIndex = i;
                    }

                    counter = 1;
                }

            }

            if (counter > maxCounter)
            {
                maxCounter = counter;
                lastIndex = array.Length - 1;
            }

            for (int i = (lastIndex-maxCounter+1); i < lastIndex+1; i++)
            {
                Console.WriteLine(array[i]);
            }

        }
    }

