using System;
using System.Globalization;

namespace _0_FrameWork.FW.Infrastrure
{
    public static class ToolString
    {
        public static PersianCalendar persianCalendar = new PersianCalendar();
        public static string EmptyValue(this string value)
        {
            if (value == "")
                return "0";

            return value;
        }

        public static int GetYearPersian(this DateTime date)
        {
            return persianCalendar.GetYear(date);
        }

        public static int GetMonthPersian(this DateTime date)
        {
            return persianCalendar.GetMonth(date);
        }

        public static int GetDaysInMonthPersian(int yaer, int month)
        {
            return persianCalendar.GetDaysInMonth(yaer, month);
        }

        public static int GetDayOfMonthPersian(this DateTime date)
        {
            return persianCalendar.GetDayOfMonth(date);
        }
        public static string GetDayPersian(this DateTime date)
        {

                string Year = persianCalendar.GetYear(date).ToString();

                string Month = persianCalendar.GetMonth(date).ToString().Length == 1 ? "0" + persianCalendar.GetMonth(date).ToString() : persianCalendar.GetMonth(date).ToString();

                string Day = persianCalendar.GetDayOfMonth(date).ToString().Length == 1 ? "0" + persianCalendar.GetDayOfMonth(date).ToString() : persianCalendar.GetDayOfMonth(date).ToString();

                return string.Format("{0}/{1}/{2}", Year, Month, Day);
        }

    }
}
