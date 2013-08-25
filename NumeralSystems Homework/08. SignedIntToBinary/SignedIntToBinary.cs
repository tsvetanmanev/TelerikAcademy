//Write a program that shows the binary representation of 
//given 16-bit signed integer number (the C# type short).


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SignedIntToBinary
    {
        static void Main()
        {
            string number = Console.ReadLine();
            bool signNegative = false;
            if (Int16.Parse(number) < 0)
            {
                signNegative = true;
            }
            ShowShortInBinary(signNegative, number);

        }

        static void ShowShortInBinary(bool sign, string input)
        {
            if (sign == false)                              
            {
                PrintArray(ReverseArray(DecimalToBinary(input)));
            }

            else                                           
            {
                byte bit = 1;
                int number = Math.Abs(Int32.Parse(input));
                input = Convert.ToString(number);
                List<byte> inputArr = ChangeDigits(input);
                for (int i = 0; i < inputArr.Count; i++)
                {
                    if (inputArr[i] + bit == 2)
                    {
                        inputArr[i] = 0;
                        bit = 1;
                    }
                    else if (bit == 1)
                    {
                        inputArr[i] = 1;
                        bit = 0;
                    }
                    if (i == (inputArr.Count - 1) && inputArr[i] == 0)
                    {
                        inputArr[i] = 1;
                        break;
                    }
                }
                PrintArray(ReverseArray(inputArr));

            }

        }

        static List<byte> AddInputToShort(List<byte> input)
        {
            for (int i = 16 - input.Count - 1; i >= 0; i--)
            {
                input.Add(0);
            }

            return input;

        }

        static List<byte> DecimalToBinary(string num)
        {
            List<byte> arr = new List<byte>();
            int dec = Int32.Parse(num);
            while (dec >= 1)
            {
                arr.Add((byte)(dec % 2));
                dec = (short)(dec / 2);
            }

            return arr;
        }

        static List<byte> ChangeDigits(string num)
        {
            List<byte> changedDigitsNum = new List<byte>();
            List<byte> numArray = DecimalToBinary(num);
            numArray = AddInputToShort(numArray);
            for (int i = 0; i < numArray.Count; i++)
            {
                if (numArray[i] == 1)
                {
                    changedDigitsNum.Add(0);
                }

                else
                {
                    changedDigitsNum.Add(1);
                }

            }

            return changedDigitsNum;
        }

        static List<byte> ReverseArray(List<byte> arr)
        {
            List<byte> reversed = new List<byte>();
            for (int i = 0; i < arr.Count; i++)
            {
                reversed.Add(arr[arr.Count - 1 - i]);
            }

            return reversed;
        }

        static void PrintArray(List<byte> arr)
        {
            if (arr.Count <= 16)
            {
                for (int i = 16 - arr.Count; i > 0; i--)
                {
                    Console.Write("0");
                }

            }

            for (int i = 0; i < arr.Count; i++)
            {
                Console.Write(arr[i]);
            }

        }
 
    }
