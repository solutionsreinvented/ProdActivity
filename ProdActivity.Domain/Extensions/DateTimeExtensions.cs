using System;

namespace ProdActivity.Domain.Extensions
{
    public static class DateTimeExtensions
    {
        public static DateTime NextBusinessDay(this DateTime fromDate)
        {
            DateTime nextBusinessDay;

            if (fromDate.DayOfWeek == DayOfWeek.Saturday)
            {
                nextBusinessDay = fromDate.AddDays(2);
            }
            else if (fromDate.DayOfWeek == DayOfWeek.Friday)
            {
                nextBusinessDay = fromDate.AddDays(3);
            }
            else
            {
                nextBusinessDay = fromDate.AddDays(1);
            }

            return nextBusinessDay;
        }
    }
}
