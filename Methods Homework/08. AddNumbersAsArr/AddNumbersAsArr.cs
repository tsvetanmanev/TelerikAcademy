//Write a method that adds two positive integer 
//numbers represented as arrays of digits (each array 
//element arr[i] contains a digit; the last digit is kept in arr[0]). 
//Each of the numbers that will be added could have up to 10 000 digits.


using System;

class AddNumbersAsArr
{
    static void PrintNumArr(int[] arr)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
        {

            Console.Write(arr[i]); // Reversed

        }
        Console.WriteLine();
    }

    static int[] Add(int[] a, int[] b)
    {
        if (a.Length > b.Length)
        {
            return Add(b, a); // We want b >= a
        }

        int[] result = new int[b.Length + 1]; // 1 + 99 = 100

        int i = 0;
        int carry = 0;

        // For each digit in both arrays
        // 1 + 67899 - once, i = 0, carry = 0
        for (; i < a.Length; i++)
        {
            result[i] = (a[i] + b[i] + carry);

            carry = result[i] / 10;
            result[i] %= 10;
        }

        // If there is still a carry: 1 + 999 - twice; 1 + 99 - once, but not with 1 + 9
        // 1 + 678999 - three times, i = 1, carry = 1
        for (; i < b.Length && carry != 0; i++)
        {
            result[i] = (b[i] + carry);

            carry = result[i] / 10;
            result[i] %= 10;
        }

        // If the second array has digits left: 1 + 100 - twice; 1 + 10 once; but not with 1 + 9 or 1 + 99
        // 1 + 678999 - twice, i = 4, carry = 0
        for (; i < b.Length; i++)
        {
            result[i] = b[i];
        }

        // If there is still a carry: 1 + 9; 1 + 99, but not 1 + 8999
        // 1 + 678999, i = 6, carry = 0, result.length = 7
        if (carry != 0) result[i] = 1;
        else Array.Resize(ref result, result.Length - 1); // Last digit not needed, remove it from the array

        return result;
    }

    // Tests
    static void Main()
    {
        int[] numArrA = new int[] { 2, 1 };
        int[] numArrB = new int[] { 8, 8, 9, 9, 9, 8, 1 };

        PrintNumArr(numArrA);
        Console.WriteLine("+");
        PrintNumArr(numArrB);
        Console.WriteLine("_________");

        int[] resultArr = Add(numArrA, numArrB);

        PrintNumArr(resultArr);
    }
}
