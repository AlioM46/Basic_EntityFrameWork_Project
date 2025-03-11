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
            int Month = Birthdate.Month - Today.Month;
            int Day= Today.Day - Birthdate.Day;
            
            if (Month < 0)
            {
                Year--;
                Month += 12;
            }
            
            if (Day < 0) {

                Day += DateTime.DaysInMonth(Today.Year, Today.Month);
            }

            return $"{Year} Year And {Month} Month And {Day} Day";


        }

    }
}
