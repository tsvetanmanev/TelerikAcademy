//Write a program that reads a rectangular matrix of size N x M 
//and finds in it the square 3 x 3 that has maximal sum of its elements.


using System;

class MaxSquare
{
    static void PrintMatrix(int[,] array)
    {
        for (int rows = 0; rows < array.GetLength(0); rows++)
        {
            for (int cols = 0; cols < array.GetLength(1); cols++)
            {
                Console.Write(" {0, 3}", array[rows, cols]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.WriteLine("Enter Size N of matrix: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Size M of matrix: ");
        int m = int.Parse(Console.ReadLine());

        int[,] rectangle = new int[n, m];

        //sample [4,4] matrix
        //{100, 2, 4, 19},
        //{1, 50, 200, 8},
        //{9, 20, 5, 2},
        //{1, 105, 6, 89},

        PrintMatrix(rectangle);

        //read the matrix' elements:

        for (int rows = 0; rows < n; rows++)
        {
            for (int cols = 0; cols < m; cols++)
            {
                Console.Write("Array [{0},{1}] = ", rows, cols );

                rectangle[rows, cols] = int.Parse(Console.ReadLine());
            }
        }

        PrintMatrix(rectangle);

        int bestSum = int.MinValue;
        int startRow = 0;
        int startCol = 0;

        for (int row = 0; row < n-2; row++)
        {
            for (int col = 0; col < m-2; col++)
            {
                int sum = rectangle[row, col] + rectangle[row, col + 1] + rectangle[row, col + 2] +
                    rectangle[row + 1, col] + rectangle[row + 1, col + 1] + rectangle[row + 1, col + 2] +
                    rectangle[row + 2, col] + rectangle[row + 2, col + 1] + rectangle[row + 2, col + 2];
                if (sum>bestSum)
                {
                    bestSum = sum;
                    startRow = row;
                    startCol = col;
                }
            }
        }


        Console.WriteLine("The maximum platform is: ");

        for (int row = startRow; row < (startRow+3); row++)
        {
            for (int col = startCol; col < (startCol+3); col++)
            {
                Console.Write(" {0, 3}", rectangle[row, col]);
            }
            Console.WriteLine();
        }



    }
}