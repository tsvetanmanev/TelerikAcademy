using System;

class CompanyData
    {
        static void Main()
        {
            Console.WriteLine("Enter company name:");
            string cName = Console.ReadLine();
            Console.WriteLine("Enter company address:");
            string cAddress = Console.ReadLine();
            Console.WriteLine("Enter company phone number:");
            string cNumber = Console.ReadLine();
            Console.WriteLine("Enter company fax number:");
            string cFax = Console.ReadLine();
            Console.WriteLine("Enter company website:");
            string cWebsite = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Enter the first name of the manager:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the last name of the manager:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the age of the manager:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enger the phone number of the manager:");
            string managerNum = Console.ReadLine();

            Console.WriteLine("The {0} company is situated in {1}. \nYou can call them on {2} or fax them on {3}. \nTheir website is {4}",
                cName, cAddress, cNumber, cFax, cWebsite);

            Console.WriteLine(" ");

            Console.WriteLine("{0} {1} is the manager of the company. \nHe is {2} years old. You can find him on {3}", firstName, lastName, age, managerNum );
        }
    }
