//11. Write a program that finds the index of given
//element in a sorted array of integers by using the 
//binary search algorithm (find it in Wikipedia).

using System;

class BinarySearch
    {
        static void Main()
        {
            int[] sortedArr = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };

            Console.Write("We have the sorted array {");

            for (int i = 0; i < sortedArr.Length; i++)
            {
                Console.Write(" {0},", sortedArr[i]);
            }
            Console.WriteLine(" } .");

            Console.WriteLine("Please enter the number you are searching for:");
            int n = int.Parse(Console.ReadLine());
            

            int middleEl = sortedArr.Length/2;
            int minEl = 0;
            int maxEl = sortedArr.Length-1;


            while (true)
            {
                if (middleEl == maxEl && maxEl == minEl && sortedArr[middleEl] != n)
                {
                    Console.WriteLine("There is no such number in the array");
                    break;
                }

                if (sortedArr[middleEl] == n)
                {
                    Console.WriteLine("The index of your number \"{0}\" is {1}", n, middleEl);
                    break;
                }

                else if (n > sortedArr[middleEl])
                {
                    if (minEl == middleEl)
                    {
                        middleEl++;
                    }
                    minEl = middleEl;
                    middleEl = (maxEl + minEl) / 2;
                }

                else if (n < sortedArr[middleEl])
                {
                    maxEl = middleEl;
                    middleEl = (maxEl + minEl) / 2;
                }

               
            }
        }
    }
