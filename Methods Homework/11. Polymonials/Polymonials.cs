//Write a method that adds two polynomials. 
//Represent them as arrays of their coefficients as in the example below:
// x2 + 5 = 1x2 + 0x + 5   501

//Extend the program to support also subtraction and multiplication of polynomials.


using System;

class Polymonials
{

    private static decimal[] MultiPoli(decimal[] firstPoli, decimal[] secondPoli)
    {
        decimal[] result = new decimal[firstPoli.Length + secondPoli.Length + 1];

        for (int i = 0; i < result.Length; i++)
        {
            result[i] = 0;
        }

        for (int i = 0; i < firstPoli.Length; i++)
        {
            for (int j = 0; j < secondPoli.Length; j++)
            {
                result[i + j] += firstPoli[i] * secondPoli[j];
            }
        }

        return result;
    }


    private static decimal[] SumPoli(decimal[] firstPoli, decimal[] secondPoli)
    {
        int maxLength = Math.Max(firstPoli.Length, secondPoli.Length);
        decimal[] result = new decimal[maxLength];
        int minLenght = 0;
        int smallerPolinomial = 0;

        if (firstPoli.Length > secondPoli.Length)
        {
            minLenght = secondPoli.Length;
            smallerPolinomial = 2;
        }
        else
        {
            minLenght = firstPoli.Length;
            smallerPolinomial = 1;
        }

        for (int i = 0; i < minLenght; i++)
        {
            result[i] = firstPoli[i] + secondPoli[i];
        }

        for (int i = minLenght; i < result.Length; i++)
        {
            if (smallerPolinomial == 1)
            {
                result[i] = secondPoli[i];
            }
            else
            {
                result[i] = firstPoli[i];
            }
        }


        return result;
    }

    private static decimal[] SubstractPoli(decimal[] firstPoli, decimal[] secondPoli)
    {
        int maxLength = Math.Max(firstPoli.Length, secondPoli.Length);
        decimal[] result = new decimal[maxLength];
        int minLenght = 0;
        int smallerPolinomial = 0;

        if (firstPoli.Length > secondPoli.Length)
        {
            minLenght = secondPoli.Length;
            smallerPolinomial = 2;
        }
        else
        {
            minLenght = firstPoli.Length;
            smallerPolinomial = 1;
        }

        for (int i = 0; i < minLenght; i++)
        {
            result[i] = firstPoli[i] - secondPoli[i];
        }

        for (int i = minLenght; i < result.Length; i++)
        {
            if (smallerPolinomial == 1)
            {
                result[i] = secondPoli[i];
            }
            else
            {
                result[i] = firstPoli[i];
            }
        }


        return result;
    }


    static void PrintPoli(decimal[] polinomial)
    {
        for (int i = polinomial.Length - 1; i >= 0; i--)
        {
            if (polinomial[i] != 0 && i != 0)
            {
                if (polinomial[i - 1] >= 0)
                {
                    Console.Write("{1}x^{0} +", i, polinomial[i]);
                }
                else
                {
                    Console.Write("{1}x^{0} ", i, polinomial[i]);
                }
            }
            else if (i == 0)
            {
                Console.Write("{0}", polinomial[i]);
            }
        }

        Console.WriteLine();
    }

    static void Main()
    {
        //input data
        decimal[] firstPoli = { 5, -1 };
        Console.Write("First polinomial:                 ");
        PrintPoli(firstPoli);

        decimal[] secondPoli = { 10, -5, 6 };
        Console.Write("Second polinomial:                ");
        PrintPoli(secondPoli);

        
        decimal[] resultSum = SumPoli(firstPoli, secondPoli);
        PrintPoli(resultSum);

        decimal[] resultSubstract = SubstractPoli(firstPoli, secondPoli);
        PrintPoli(resultSubstract);

        decimal[] resultMulti = MultiPoli(firstPoli, secondPoli);
        PrintPoli(resultMulti);
    }


}