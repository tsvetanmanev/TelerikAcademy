//Write a program, that reads from the console an array of N integers 
//and an integer K, sorts the array and using the method Array.BinSearch() 
//finds the largest number in the array which is ≤ K. 


using System;

class BinSearchSort
{
    static void Main()
    {
        Console.WriteLine("Enter Size N of matrix: ");
        int n = int.Parse(Console.ReadLine());
        

        int[] myArr = new int[n];

        //{ 10, 25, 7, 14, 5, 10, 20, 29 }
        Console.WriteLine("Enter integers of the array on separate lines");
        for (int i = 0; i < n; i++)
        {
            myArr[i] = int.Parse(Console.ReadLine());
        }
        
        Console.WriteLine("Enter integer K to search in the array: ");
        int k = int.Parse(Console.ReadLine());
        
        Array.Sort(myArr);
        Console.WriteLine("The array is sorted: ");
        foreach (int number in myArr)
        {
            Console.Write("{0} ,",number);
        }
        Console.WriteLine();
        

        int indexOfEl = Array.BinarySearch(myArr, k);

        if (indexOfEl < 0)
        {
            Console.WriteLine("The object is not found. The next larger object is {0}.", myArr[~indexOfEl]);
        }
        else
        {
            Console.WriteLine("The index of this element is ({0})", indexOfEl);
        } 
    }
}
