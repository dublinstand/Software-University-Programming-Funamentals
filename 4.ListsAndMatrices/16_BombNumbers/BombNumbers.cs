using System;
using System.Collections.Generic;
using System.Linq;

//Write a program that reads sequence of numbers and special bomb number with a certain power.
//    Your task is to detonate every occurrence of the special bomb number and according to its power his neighbors from left and right. 
//    Detonations are performed from left to right and all detonated numbers disappear. 
//    Finally print the sum of the remaining elements in the sequence.

class BombNumbers
{
    static void Main()
    {
        List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        int[] token = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int bombNumber = token[0];
        int bombPower = token[1];

        for (int i = 0; i < nums.Count; i++)
        {
            if (nums[i] == bombNumber)
            {
                int left = Math.Max(i - bombPower, 0);

                int right = Math.Min(i + bombPower, nums.Count - 1);

                int lenght = right - left + 1;
                nums.RemoveRange(left, lenght);
                i = 0;
            }
        }
        Console.WriteLine(nums.Sum());


    }

}

