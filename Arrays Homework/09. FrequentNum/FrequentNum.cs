//write a program that finds the most frequent number in an array. 
//example:
//    {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}     ->    4 (5 times)


using System;

class FrequentNum
    {
        static void Main()
        {
            int[] myArr = { 1, 2, 1, 4, 2, 3, 4, 2, 1, 2, 9, 2 };
            int minValue = 0;
            int repeats = 0;
            int maxRepeats = 0;

            for (int i = 0; i < myArr.Length; i++)
            {
                for (int j = i; j < myArr.Length - i; j++)
                {

                    if (myArr[i] == myArr[j])
                    {
                        repeats++;
                        if (repeats > maxRepeats)
                        {
                            minValue = myArr[i];
                            maxRepeats = repeats;
                        }
                    }
                }
                repeats = 0;
            }

            if (minValue == myArr[myArr.Length-1])
            {
                maxRepeats++;
            }

            Console.Write(minValue);
            Console.WriteLine(" ({0} times)", maxRepeats);
        }
    }
