//Write a program that finds in given array of integers a sequence of given
//sum S (if present). 
//Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}	


using System;

class SearchSeqSum
    {
        static void Main()
        {
            int[] myArr = new int[] { 4, 3, 3, 1, 4, 2, 5};
            int sum = 11;

            int currentSum = 0;
            int startIndex = 0;
            int endIndex = 0;

            for (int i = 0; i < myArr.Length; i++)
            {
                for (int j = i; j < myArr.Length; j++)
                {
                    
                    currentSum += myArr[j];

                    if (currentSum > sum)
                    {
                        break;
                    }

                    else if (currentSum == sum)
                    {
                        startIndex = i;
                        endIndex = j;
                        break;
                    }
                }

                currentSum = 0;
            }

            if (startIndex == endIndex)
            {
                Console.WriteLine("There is no such sequence");
            }

            else
            {
                Console.Write("{");

                for (int i = startIndex; i < endIndex+1; i++)
                            {
                                Console.Write(" {0},", myArr[i]);
                            }
                Console.WriteLine(" }");
            }
            

        }
    }
