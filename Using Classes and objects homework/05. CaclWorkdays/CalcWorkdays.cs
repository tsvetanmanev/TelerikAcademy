//Write a method that calculates the number of workdays 
//between today and given date, passed as parameter. 
//Consider that workdays are all days 
//from Monday to Friday except a fixed list of public 
//holidays specified preliminary as array.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CalcWorkdays
{
    public static DateTime[] pubHolidays = new DateTime[]
        {
            new DateTime(2013, 1, 1),
            new DateTime(2013, 1, 2),
            new DateTime(2013, 5, 3),
            new DateTime(2013, 5, 4), 
            new DateTime(2013, 5, 5), 
            new DateTime(2013, 5, 6), 
            new DateTime(2013, 5, 1), 
            new DateTime(2013, 5, 24), 
            new DateTime(2013, 9, 6), 
            new DateTime(2013, 9, 22), 
            new DateTime(2013, 10, 1), 
            new DateTime(2013, 12, 24), 
            new DateTime(2013, 12, 25), 
            new DateTime(2013, 12, 6), 
            // etc
        };

    private static int CaclulateWorkDays(DateTime endDate)
    {
        int sumOfWorkDays = 0;
        DateTime today = DateTime.Now;
        System.TimeSpan lengthOfPeriod = endDate - today;
        int daysBetweenDates = lengthOfPeriod.Days;


        for (int i = 0; i < daysBetweenDates; i++)
        {
            bool isHoliday = false;
            if (today.DayOfWeek.ToString() == "Saturday" || today.DayOfWeek.ToString() == "Sunday")
            {

            }

            else
            {
                for (int j = 0; j < pubHolidays.Length; j++)
                {
                    if (today.Month == pubHolidays[j].Month && today.Day == pubHolidays[j].Day)
                    {
                        isHoliday = true;
                    }
                }

                if (isHoliday == false)
                {
                    sumOfWorkDays++;
                }

            }

            today = today.AddDays(1);
        }

        return sumOfWorkDays;
    }

    static void Main()
    {


        Console.WriteLine("Please enter a future date to calculate the working days. Enter the year, month and day each on a separate line:");

        int year = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int day = int.Parse(Console.ReadLine());

        DateTime endDate = new DateTime(year, month, day);



        int workDays = CaclulateWorkDays(endDate);

        Console.WriteLine("There are {0} workdays between today and {1}.", workDays, endDate);
    }

}
