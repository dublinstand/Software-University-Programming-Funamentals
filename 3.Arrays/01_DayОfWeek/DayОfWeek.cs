using System;



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

