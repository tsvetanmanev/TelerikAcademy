//Sorting an array means to arrange its elements in increasing order.
//Write a program to sort an array. Use the "selection sort" algorithm:
//Find the smallest element, move it at the first position, 
//find the smallest from the rest, move it at the second position, etc.


using System;

class SelectionSortArray
    {
        static void Main()
        {
            int[] myArr = new int[] { 3, 2, 3, 4, 5, 1, 2, 3, 4, 7 };

            int smallestEl = 0;
            int smallestIndx = 0;

            for (int i = 0; i < myArr.Length; i++)
            {
                smallestEl = myArr[i];
                smallestIndx = i;

                for (int j = i+1; j < myArr.Length; j++)
                {
                    if (myArr[j] < myArr[i])
                    {
                        smallestIndx = j;
                    }

                    myArr[smallestIndx] = smallestEl;

                }
            }


            foreach (int element in myArr)
            {
                Console.WriteLine(element);
            }
        }
    }
