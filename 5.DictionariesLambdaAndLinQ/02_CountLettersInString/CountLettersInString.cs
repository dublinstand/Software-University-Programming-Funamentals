using System;
using System.Collections.Generic;
using System.Linq;

//Read a string and count how many times each character occurs.Print all chars(case insensitive) alphabetically with their counts.

class CountLettersInString
{
    static void Main()
    {
        string words = Console.ReadLine().ToLower();

        int[] counts = new int[words.Max() + 1];

        foreach (char ch in words)
        {
            counts[ch]++;

        }

        for (char ch = (char)0; ch < counts.Length; ch++)
        {
            if (counts[ch] != 0)
            {
                Console.WriteLine("{0} -> {1}", ch, counts[ch]);
            }

        }
    }
}

