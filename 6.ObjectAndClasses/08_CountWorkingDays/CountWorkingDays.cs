using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

//Write a program that reads two dates in format dd-MM-yyyy and prints the number of working days between these two dates inclusive.Non-working days are:
//•	All days that are Saturday or Sunday.
//•	All days that are official holidays in Bulgaria:
//o New Year Eve(1 Jan)
//o Liberation Day(3 March)
//o Worker’s day(1 May)
//o Saint George’s Day(6 May)
//o Saints Cyril and Methodius Day(24 May)
//o Unification Day(6 Sept)
//o Independence Day(22 Sept)
//o National Awakening Day(1 Nov)
//o Christmas(24, 25 and 26 Dec)
//All days not mentioned above are working and should count.


class CountWorkingDays
{
    static void Main()
    {
        DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
        DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
        int workingDays = 0;

        DateTime[] officialHolidays = new DateTime[]
        {
            new DateTime(4, 1, 1),
            new DateTime(4, 3, 3),
            new DateTime(4, 5, 1),
            new DateTime(4, 5, 6),
            new DateTime(4, 5, 24),
            new DateTime(4, 9, 6),
            new DateTime(4, 9, 22),
            new DateTime(4, 11, 1),
            new DateTime(4, 12, 24),
            new DateTime(4, 12, 25),
            new DateTime(4, 12, 26)
        };

        for (DateTime d = startDate; d <= endDate; d = d.AddDays(1))
        {
            DateTime tempDate = new DateTime(4, d.Month, d.Day);
            bool isWeekDay = d.DayOfWeek != DayOfWeek.Saturday && d.DayOfWeek != DayOfWeek.Sunday;
            bool isHoliday = officialHolidays.Contains(tempDate);

            if (isWeekDay && !isHoliday)
            {
                workingDays++;
            }
        }

        Console.WriteLine(workingDays);
    }
}

