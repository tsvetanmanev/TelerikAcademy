using System;

class SortNums
    {
        static void Main()
        {
            decimal num1 = decimal.Parse(Console.ReadLine());
            decimal num2 = decimal.Parse(Console.ReadLine());
            decimal num3 = decimal.Parse(Console.ReadLine());

            decimal first = 0;
            decimal second = 0;
            decimal third = 0;

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    first = num1;

                    if (num2 > num3)
                    {
                        second = num2;
                        third = num3;
                    }

                    else
                    {
                        second = num3;
                        third = num2;
                    }
                }
                else if (num3 > num1)
                {
                    first = num3;
                    second = num1;
                    third = num2;
                }
            }
            else
            {
                if (num2 > num3)
                {
                    first = num2;

                    if (num1 > num3)
                    {
                        second = num1;
                        third = num3;
                    }
                    else
                    {
                        second = num3;
                        third = num1;
                    }
                }
                else if (num3 > num1)
                {
                    first = num3;
                    second = num2;
                    third = num3;
                }
            }

            Console.WriteLine(" ");
            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(third);
        }
    }
