using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    public class DateService
    {
        public static DayOfWeek GetDay(DateTime date)
        {
            return date.DayOfWeek;
        }
        public static int GetDaysSpan (int day, int month, int year)
        {
            DateTime dat5 = new DateTime(year, month, day);
            TimeSpan span5 = DateTime.UtcNow - dat5;
            return span5.Days;
        }        
    }
}
