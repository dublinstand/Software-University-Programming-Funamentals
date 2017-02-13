using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Read a list of integers, remove all negative numbers from it and print the remaining elements in 
//reversed order.In case of no elements left in the list, print “empty”.

class RemoveNegativeAndReverse
{
    static void Main()
    {
        List<int> numbersList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        List<int> results = new List<int>();

        foreach(int num in numbersList)
        {
            if (num > 0)
            {
                results.Add(num);
            }
        }

        results.Reverse();

        if (results.Count > 0)
        {
            Console.WriteLine(string.Join(" ", results));
        }
        else
        {
            Console.WriteLine("Empty");
        }

    }
}

