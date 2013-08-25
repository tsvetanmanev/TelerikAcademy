using System;

class PrintMatrix2
{
    static int[,] integersArray;
    static int typeCCurrentNumber = 1;

    static void PrintArray()
    {
        for (int row = 0; row < integersArray.GetLength(0); row++)
        {
            for (int col = 0; col < integersArray.GetLength(1); col++)
            {
                Console.Write("{0, 3} ", integersArray[row, col]);
            }

            Console.WriteLine();
        }
    }

    static void FillDiagonally(int row, int col)
    {
        while (true)
        {
            // Check if we are our of the boundaries of the array and break the loop if we are
            if (row == integersArray.GetLength(0) || col == integersArray.GetLength(1))
            {
                break;
            }

            integersArray[row, col] = typeCCurrentNumber;
            typeCCurrentNumber++;

            // Move diagonally
            row++;
            col++;
        }
    }

    static void FillMatrixTypeA()
    {
        // In this matrix we simply print the numbers on each column by starting on the first row
        int currentNumber = 1;

        for (int col = 0; col < integersArray.GetLength(1); col++)
        {
            for (int row = 0; row < integersArray.GetLength(0); row++)
            {
                integersArray[row, col] = currentNumber;
                currentNumber++;
            }
        }

        PrintArray();
    }

    static void FillMatrixTypeB()
    {
        // In this matrix  we print each column by going "down - up - down - up"

        int row = 0;
        int col = 0;
        string direction = "down";
        int numberOfIntegersToInput = integersArray.GetLength(0) * integersArray.GetLength(0);

        for (int currentNumber = 1; currentNumber <= numberOfIntegersToInput; currentNumber++)
        {
            /* Check if we are out of the boundaries of the array. If the row is N, than we need to go to the next column and start going up.
             * If row is negative, we must again move to the next column, but start moving down again */

            if (row == integersArray.GetLength(0))
            {
                row--;
                col++;
                direction = "up";
            }

            if (row < 0)
            {
                row++;
                col++;
                direction = "down";
            }

            integersArray[row, col] = currentNumber;

            // Change the row, depending on the direction

            if (direction == "down")
            {
                row++;
            }
            else
            {
                row--;
            }
        }

        PrintArray();
    }

    static void FillMatrixTypeC()
    {
        // We fill this matrix by going through all elements in row 0 and column 0 by starting at the bottom-left corner and filling diagonally

        int row = integersArray.GetLength(0) - 1;
        int col = 0;
        string direction = "up";

        for (int i = 1; i < (2 * integersArray.GetLength(0)); i++)
        {
            // Check if we are at {0, 0} and need to change the direction
            if (row == 0 & col == 0)
            {
                direction = "right";
            }

            // Fill in the elements diagonally from the current cell and get the last printed number from the FillDiagonally method
            FillDiagonally(row, col);

            if (direction == "up")
            {
                row--;
            }
            else
            {
                col++;
            }
        }

        PrintArray();
    }

    static void FillMatrixTypeD()
    {
        // We fill this matrix by going through a "down - right - up - left" spiral by starting at the top-right corner of the matrix

        int row = 0;
        int col = 0;
        string direction = "down";
        int numberOfIntegersToInput = integersArray.GetLength(0) * integersArray.GetLength(0);

        /* We will use the nextRow and nextCol variable to check what is the next cell we are going to visit. They will depend on the direction,
         * so we will start with nextRow = 1 and nextCol = 0, since were are moving down ar first */
        int nextRow = 1;
        int nextCol = 0;

        for (int currentNumber = 1; currentNumber <= numberOfIntegersToInput; currentNumber++)
        {
            // Fill in the cell
            integersArray[row, col] = currentNumber;

            // Check if we need to change direction (that will be when the next cell is out boundaries OR is filled)
            bool switchDirection = false;

            if (((row + nextRow) == integersArray.GetLength(0)) || ((col + nextCol) == integersArray.GetLength(1)) ||
                ((row + nextRow) < 0) || ((col + nextCol) < 0))
            {
                switchDirection = true;
            }
            else if (((row + nextRow) < integersArray.GetLength(0)) || ((col + nextCol) < integersArray.GetLength(1)) ||
                    ((row + nextRow) >= 0) || ((col + nextCol) >= 0))
            {
                if (integersArray[(row + nextRow), (col + nextCol)] != 0)
                {
                    switchDirection = true;
                }
            }

            if (switchDirection)
            {
                switch (direction)
                {
                    case "down": direction = "right"; break;
                    case "right": direction = "up"; break;
                    case "up": direction = "left"; break;
                    case "left": direction = "down"; break;
                    default: break;
                }
            }

            // Apply direction
            if (direction == "down")
            {
                nextRow = 1;
                nextCol = 0;
            }
            else if (direction == "up")
            {
                nextRow = -1;
                nextCol = 0;
            }
            else if (direction == "right")
            {
                nextRow = 0;
                nextCol = 1;
            }
            else
            {
                nextRow = 0;
                nextCol = -1;
            }

            row += nextRow;
            col += nextCol;
        }

        PrintArray();
    }

    static void Main()
    {
        // Write a program that fills and prints a matrix of size (n, n) 

        // Get the number N from the user, create the array and get the type of matrix to be printed
        Console.Write("Please enter the dimention of the square matrix: ");
        int arrayDimention = 4;

        integersArray = new int[arrayDimention, arrayDimention];

        Console.Write("\nPlease enter the type of matrix to print (a, b, c or d): ");
        string matrixType = "c";

        // Print the matrix
        Console.WriteLine();

        switch (matrixType)
        {
            case "a": FillMatrixTypeA(); break;
            case "b": FillMatrixTypeB(); break;
            case "c": FillMatrixTypeC(); break;
            case "d": FillMatrixTypeD(); break;
            default: Console.WriteLine("You did not choose a valid type. You must type a, b, c or d."); break;
        }

        Console.WriteLine();
    }
}