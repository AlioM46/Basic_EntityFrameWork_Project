using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork
{
    public class Utilities
    {
        public static string CalculateAge(DateTime Birthdate)
        {
            DateTime Today = DateTime.Now;

            int Year = Today.Year - Birthdate.Year;
            int Month = Today.Month - Birthdate.Month;
            int Day = Today.Day - Birthdate.Day;

            // Adjust the month and year if the month difference is negative
            if (Month < 0)
            {
                Year--;
                Month += 12;
            }

            // Adjust the day and month if the day difference is negative
            if (Day < 0)
            {
                // Subtract the previous month’s last day to get the correct days
                Month--;


                Day += DateTime.DaysInMonth(Today.Year, Today.Month - 1); // Get the days of the previous month


            }
            return $"{Year} Year And {Month} Month And {Day} Day";

        }

    }
}
