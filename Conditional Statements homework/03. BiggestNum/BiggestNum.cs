using System;

class BiggestNum
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int bigNum = 0;

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    bigNum = num1;
                }
                else if (num3 > num1)
                {
                    bigNum = num3;
                }
            }
            else
            {
                if (num2 > num3)
                {
                    bigNum = num2;
                }
                else if (num3 > num1)
                {
                    bigNum = num3;
                }
            }


            Console.WriteLine("The biggest number is " +bigNum);
        }
    }
