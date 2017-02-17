using System;
using System.Collections.Generic;
using System.Linq;


//Read a list of integers and find the longest increasing subsequence(LIS). If several such exist, print the leftmost.


class LongestIncreasingSubsequence
{
    static void Main(string[] args)
    {
        List<int> integersList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
    }
}

