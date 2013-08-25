//20. Write a program that reads two numbers N and
//K and generates all the variations of K elements
//from the set [1..N]. Example:
//N = 3, K = 2 -> {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, 
//{2,3}, {3, 1}, {3, 2}, {3, 3}

using System;

class Program
{
    static int[] combination;
    static int n;
    static void Main(string[] args)
    {
        Console.WriteLine("Enter maximum number of the set N");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the K elements in the set");
        int k = int.Parse(Console.ReadLine());

        combination = new int[k];

        PrintVariations(0);
    }

    static void PrintVariations(int index)
    {
        if (index >= combination.Length)
        {
            Console.Write("{");
            for (int i = 0; i < combination.Length; i++)
            {
                Console.Write(" {0},",combination[i]);
            }
            Console.WriteLine("}");
        }

        else
        {
            for (int i = 1; i <= n; i++)
                {
                    combination[index] = i;
                    PrintVariations(index + 1);
                }
        }
        
    }
}

