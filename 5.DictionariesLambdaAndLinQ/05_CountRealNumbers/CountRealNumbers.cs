using System;
using System.Collections.Generic;
using System.Linq;

//Read a list of real numbers and print them in ascending order along with their number of occurrences.

class CountRealNumbers
{
    static void Main()
    {
        double[] nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

        SortedDictionary<double, int> counts = new SortedDictionary<double, int>();

        foreach (double num in nums)
        {
            if (!counts.ContainsKey(num))
            {
                counts[num] = 1;
            }
            else
            {
                counts[num]++;
            }
        }

        foreach (var num in counts)
        {
            Console.WriteLine("{0} -> {1}", num.Key, num.Value);
        }
         
    }
}

