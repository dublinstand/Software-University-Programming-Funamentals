using System;

//Enter a day number[1…7] and print the day name(in English) or “Invalid Day!”. Use an array of strings.

class DayОfWeek
{
    static void Main()
    {
        string[] week = { "Monday" , "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        int dayOfWeek = int.Parse(Console.ReadLine());

        if (dayOfWeek >= 1 && dayOfWeek <= 7)
        {
            Console.WriteLine(week[dayOfWeek - 1]);
        }
        else
        {
            Console.WriteLine("Invalid Day!"); 
        }

    }
}

