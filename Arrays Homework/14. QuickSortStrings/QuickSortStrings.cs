//Write a program that sorts an array of strings using the quick sort algorithm 
//(find it in Wikipedia).

// Used Jasssonpet homework as source as I have yet to understand recursion.
//source: Jasssonpet homework: https://github.com/jasssonpet/TelerikAcademy/blob/master/Programming/2.CSharpPartTwo/1.Arrays/14.QuickSort/Program.cs
//reworked to take arrays of strings

using System;

class Program
{
    static void Swap(string[] arr, int i, int j)
    {
        string t = arr[i];
        arr[i] = arr[j];
        arr[j] = t;
    }

    static int Partition(string[] arr, int l, int r)
    {
        Swap(arr, new Random().Next(l, r + 1), r);
        string pivot = arr[r];
        int i = l;

        for (int j = l; j < r; j++) if (String.Compare(arr[j], pivot) <= 0 /*arr[j] <= pivot*/) Swap(arr, i++, j);
        Swap(arr, i, r);

        return i;
    }

    static void QuickSort(string[] arr, int l, int r)
    {
        if (l >= r) return;

        int q = Partition(arr, l, r);

        QuickSort(arr, l, q - 1);
        QuickSort(arr, q + 1, r);
    }

    static void Main()
    {
        string[] arr = { "Zeratul", "Car", "Relationship", "Apple", "Bungee", "sound", "soundproof", "troublesome"};

        Console.WriteLine("Original array:");

        foreach (string item in arr) Console.WriteLine(item);

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Sorting array...");
        Console.WriteLine();
        Console.WriteLine();

        QuickSort(arr, 0, arr.Length - 1);

        Console.WriteLine("Array sorted: ");
        foreach (string item in arr) Console.WriteLine(item);
        Console.WriteLine();
    }
}