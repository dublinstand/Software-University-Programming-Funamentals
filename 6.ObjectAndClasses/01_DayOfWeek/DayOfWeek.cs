using System;
using System.Globalization;
using System.Linq;

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