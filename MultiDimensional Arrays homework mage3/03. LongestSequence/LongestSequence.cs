//We are given a matrix of strings of size N x M. 
//Sequences in the matrix we define as sets of several neighbor elements 
//located on the same line, column or diagonal. 
//Write a program that finds the longest sequence of equal strings in the matrix. 
//Example:

//ha fifi ho hi
//fo  ha  hi xx  -> ha, ha, ha
//xxx ho  ho xx  

// s qq s
//pp pp s  -> s, s, s 
//pp qq s


using System;

class LongestSequence
{
    static void PrintMatrix(string[,] array)
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
        string[,] matrix = new string[3,4]
            {
                {"ha", "fifi", "s", "s"},
                {"fo", "ha", "hi", "s"},
                {"xx", "s", "ha", "fo"},
            };

        string element = "Wrong";
        int counter = 0;
        int bestCounter = 0;


        PrintMatrix(matrix);

        ////check horizontal direction
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1) - 1; cols++)
            {
                if (matrix[rows, cols] == matrix[rows, cols + 1])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }

                if (counter > bestCounter)
                {
                    bestCounter = counter;
                    element = matrix[rows, cols];
                }
            }
        }

        //check all verticals
        for (int cols = 0; cols < matrix.GetLength(1); cols++)
        {
            for (int rows = 0; rows < matrix.GetLength(0) - 1; rows++)
            {
                if (matrix[rows, cols] == matrix[rows + 1, cols])
                {
                    counter++;
                }

                else
                {
                    counter = 1;
                }

                if (counter > bestCounter)
                {
                    bestCounter = counter;
                    element = matrix[rows, cols];
                }
            }
            counter = 1;
        }

        //check right-down diagonals
        for (int i = 0; i < matrix.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                for (int rows = i, cols = j; rows < matrix.GetLength(0) - 1 && cols < matrix.GetLength(1) - 1 ; rows++, cols++)
                {
                    if (matrix[rows, cols] ==  matrix[rows+1, cols+1])
                    {
                        counter++;
                    }

                    else
                    {
                        counter = 1;
                    }

                    if (counter > bestCounter)
                    {
                        bestCounter = counter;
                        element = matrix[rows, cols];
                    }
                }
                counter = 1;
            }
        }

        //check diagonals from top right to down left

        for (int i = 0; i < matrix.GetLength(0) - 1; i++)
        {
            for (int j = 1; j < matrix.GetLength(1); j++)
            {
                for (int rows = i, cols = j; rows < matrix.GetLength(0) - 1 && cols > 0; rows++, cols--)
                {
                    if (matrix[rows, cols] == matrix[rows + 1, cols])
                    {
                        counter++;
                    }

                    else
                    {
                        counter = 1;
                    }

                    if (counter > bestCounter)
                    {
                        bestCounter = counter;
                        element = matrix[rows, cols];
                    }
                }
                counter = 1;
            }
        }

        for (int i = 0; i < bestCounter; i++)
        {
            if (i == bestCounter - 1)
            {
                Console.Write("{0}", element);
            }
            else
            {
                Console.Write("{0}, ", element);
            }
            
        }
        Console.WriteLine();

    }
}
