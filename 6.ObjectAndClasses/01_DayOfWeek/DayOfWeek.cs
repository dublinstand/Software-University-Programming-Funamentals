using System;
using System.Globalization;
using System.Linq;

//You are given a date in format day-month-year.Calculate and print the day of week in English.

class DayOfWeek
{
    static void Main()
    {
        string dateStr = Console.ReadLine();
        var tokens = dateStr.Split('-').Select(int.Parse);
        var date = DateTime.ParseExact(dateStr, "d-M-yyyy", CultureInfo.InvariantCulture);
        Console.WriteLine(date.DayOfWeek);
    }
}