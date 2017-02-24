using System;
using System.Collections.Generic;
using System.Linq;

//Read a list of real numbers and print largest 3 of them.If less than 3 numbers exit, print all of them.

class Largest3Numbers
{
    static void Main()
    {
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Console.WriteLine(string.Join(" ", nums.OrderByDescending(x => x).Take(3)));

    }
}

