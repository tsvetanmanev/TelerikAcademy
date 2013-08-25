    //Write a program that fills and prints a matrix of size (n, n) as shown below:
    //(examples for n = 4)

    //a)                 b)
    //1 5 9  13          1 8 9  16
    //2 6 10 14          2 7 10 15
    //3 7 11 15          3 6 11 14
    //4 8 12 16          4 5 12 13

    //c)                 d)*
    //7 11 14 16          1 12 11 10
    //4  8 12 15          2 13 16  9
    //2  5  9 13          3 14 15  8
    //1  3  6 10          4  5  6  7

using System;

class PrintArrays
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());


        int[,] arrayA = new int[n, n];

        for (int cols = 0; cols < n; cols++)
        {
            for (int rows = 0; rows < n; rows++)
            {
                arrayA[rows, cols] = (n * cols) + rows + 1;
            }
        }

        int[,] arrayB = new int[n, n];

        for (int cols = 0; cols < n; cols++)
        {
            for (int rows = 0; rows < n; rows++)
            {
                if (cols % 2 == 0)
                {
                    arrayB[rows, cols] = (n * cols) + rows + 1;
                }

                else
                {
                    arrayB[rows, cols] = (n * (cols + 1)) - rows;
                }

            }
        }

        int[,] arrayC = new int[n, n];

        int row = arrayC.GetLength(0) - 1;
        int col = 0;
        string direction = "up";
        int currentNumber = 1;

        for (int i = 1; i < (2 * arrayC.GetLength(0)); i++)
        {
            // Check if we are at {0, 0} and need to change the direction
            if (row == 0 & col == 0)
            {
                direction = "right";
            }

            int backRow = row;
            int backCol = col;

            while (true)
            {
                if (row == arrayC.GetLength(0) || col == arrayC.GetLength(1))
                {
                    break;
                }

                arrayC[row, col] = currentNumber;
                currentNumber++;

                row++;
                col++;
            }

            row = backRow;
            col = backCol;

            if (direction == "up")
            {
                row--;
            }
            else
            {
                col++;
            }
        }



        //PrintMatrix(arrayA);
        //PrintMatrix(arrayB);
        PrintMatrix(arrayC);
    }

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
}
