using System;
using System.Collections.Generic;
using System.Linq;

//Read a list of integers in range[0…1000] and print them in ascending order along with their number of occurrences.

class CountNumbers
{
    static void Main()
    {
        List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        int[] count = new int[nums.Max() + 1];

        foreach(int num in nums)
        {
            count[num]++;
        }

        for (int i = 0; i < count.Length; i++)
        {
            if (count[i] != 0)
            {
                Console.WriteLine(i + " -> " + count[i]);
            }
        }
    }
}

