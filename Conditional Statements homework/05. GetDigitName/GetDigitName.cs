﻿using System;

class GetDigitName
    {
        static void Main()
        {
            Console.WriteLine("Enter a digit (from 0 to 9) to receive its spelling");
            sbyte n = sbyte.Parse(Console.ReadLine());

            switch (n)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;

                default:
                    Console.WriteLine("You did not enter a number between Zero to Ten");
                    break;
            }
            

        }
    }
