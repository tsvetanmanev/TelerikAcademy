using System;

class CharCompare
    {
        static void Main()
        {
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();

            int result = string.Compare(firstString, secondString);

            if (result < 0)
            {
                Console.WriteLine("The second string is greater");
            }

            else if (result > 0)
            {
                Console.WriteLine("The first string is greater");
            }

            else if (result == 0)
            {
                Console.WriteLine("The strings are equal");
            }


        }
    }
