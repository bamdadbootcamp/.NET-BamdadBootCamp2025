using System.Globalization;

namespace System;

public static class CalendarUtility
{

    public static string Gregorian2Shamsi(this DateTime dateTime, char seprator) // Extension method
    {
        PersianCalendar persianCalendar = new PersianCalendar();

        int day = persianCalendar.GetDayOfMonth(dateTime);
        int month = persianCalendar.GetMonth(dateTime);
        int year = persianCalendar.GetYear(dateTime);

        return $"{year}{seprator}{month}{seprator}{day}";
    }
    public static DateTime Shamsi2Gregorian(string persianDate) // 1404/02/11
    {
        PersianCalendar persianCalendar = new PersianCalendar();

        var persianDateParts = persianDate.Split('/');
        int year = int.Parse(persianDateParts[0]);
        int month = int.Parse(persianDateParts[1]);
        int day = int.Parse(persianDateParts[2]);

        return persianCalendar.ToDateTime(year, month, day, 0, 0, 0, 0);
    }
}