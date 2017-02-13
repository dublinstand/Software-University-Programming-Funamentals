using System;
using System.Collections.Generic;

//Write a program to append several lists of numbers.
//	Lists are separated by ‘|’.
//	Values are separated by spaces(‘ ’, one or several)
//	Order the lists from the last to the first, and their values from left to right.


class AppendLists
{
    static void Main()
    {
        string[] lists = Console.ReadLine().Split('|');
        List<string> results = new List<string>();

        for (int i = lists.Length - 1; i >= 0; i--)
        {
            string[] list = lists[i].Split(' ');

            foreach(string item in list)
            {
                if(!item.Equals(""))
                {
                    results.Add(item);
                }
            }     
        }

        Console.WriteLine(string.Join(" ", results));
    }
}

