using System;

class ChooseInput
    {
        static void Main()
        {
            Console.WriteLine("Type 1 for int, 2 for double or 3 for string");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Now please input number");
                    int n = int.Parse(Console.ReadLine());
                    Console.WriteLine(n+1);
                    break;
                case 2:
                    Console.WriteLine("Now please input number");
                    double d = double.Parse(Console.ReadLine());
                    Console.WriteLine(d + 1);
                    break;
                case 3:
                    Console.WriteLine("Now please input text");
                    string str = Console.ReadLine();
                    string newStr = str + '*';
                    Console.WriteLine(newStr);
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }


        }
    }
