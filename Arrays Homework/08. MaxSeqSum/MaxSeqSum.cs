//Write a program that finds the sequence of maximal sum in given array. 
//Example:
//    {2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
//Can you do it with only one loop
//(with single scan through the elements of the array)?



using System;

class MaxSeqSum
    {
        static void Main()
        {
            int[] myArr = new int[] { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

            int maxSum = 0;
            int currentSum = 0;

            int firstIndx = 0;
            int lastIndx = 0;

            for (int i = 0; i < myArr.Length-3; i++)
            {
                if (myArr[i] + myArr[i+1] + myArr[i+2] + myArr[i+3] > 0)
                {
                    currentSum = myArr[i] + myArr[i + 1] + myArr[i + 2] + myArr[i+3];
                }

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    firstIndx = i;
                    lastIndx = i + 3;
                }
            }
            Console.Write("{");
            for (int i = firstIndx; i <= lastIndx; i++)
            {
                Console.Write(" {0},", myArr[i]);
            }
            Console.WriteLine(" }");
        }
    }
