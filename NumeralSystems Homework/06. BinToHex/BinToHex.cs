﻿//Write a program to convert binary numbers to hexadecimal numbers (directly).


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinToHex
{
    static void Main()
    {
        Console.WriteLine("Please enter a binary number:");
        string input = Console.ReadLine();



        string result = "";

        for (int i = 0; i < input.Length-3; i+=4)
        {
            string check = String.Concat(input[i], input[i+1], input[i+2], input[i+3]);
            switch (check)
            {
                case "0000": result += "0"; break;
                case "0001": result += "1"; break;
                case "0010": result += "2"; break;
                case "0011": result += "3"; break;
                case "0100": result += "4"; break;
                case "0101": result += "5"; break;
                case "0110": result += "6"; break;
                case "0111": result += "7"; break;
                case "1000": result += "8"; break;
                case "1001": result += "9"; break;
                case "1010": result += "A"; break;
                case "1011": result += "B"; break;
                case "1100": result += "C"; break;
                case "1101": result += "D"; break;
                case "1110": result += "E"; break;
                case "1111": result += "F"; break;
                default:

                    break;
            }
        }

        Console.WriteLine("The hexademical number is:");
        Console.WriteLine(result);
            
    }
}