using System;

//Calculate how many courses will be needed to elevate n persons by using an elevator of capacity of p persons.
//The input holds two lines: the number of people n and the capacity p of the elevator.

class Elevator
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());

        int courses = n / p;
        if (n % p != 0)
        {
            courses++;
        }

        //int courses2 = (int)Math.Ceiling((double) n / p);  - Math.Celeing rounds to the higher number

        Console.WriteLine(courses);
    }
}

