//12. Write a program that creates an array containing
//all letters from the alphabet (A-Z). Read a word
//from the console and print the index of each of its 
//letters in the array.


using System;

class AlphabetIndex
    {
        static void Main()
        {
            Console.WriteLine("Please enter a word");
            string input = Console.ReadLine();
            string lowCase = input.ToLower();

            char[] alphabet = 
            {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};

            

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (lowCase[i] == alphabet[j])
                    {
                        Console.WriteLine("The alphabet index of letter \"{0}\" is [{1}];", input[i], j);
                    }
                }
            }
        }
    }
