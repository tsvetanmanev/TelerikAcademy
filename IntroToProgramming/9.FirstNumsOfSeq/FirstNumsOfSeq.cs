using System;

class FirstNumsOfSeq
    {
        static void Main()
        {
            int start = 2;
            int lenght = start + 10;
            for (int i = start; i < lenght; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

                else
                {
                    Console.WriteLine("-" + i);
                }
            }
        }
    }
