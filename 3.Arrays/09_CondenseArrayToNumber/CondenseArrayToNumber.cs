using System;
using System.Linq;

//Write a program to read an array of integers and condense them by summing adjacent couples of 
//    elements until a single integer is obtained.For example, if we have 3 elements {2, 10, 3}, 
//    we sum the first two and the second two elements and obtain {2+10, 10+3} = { 12, 13 }, 
//    then we sum again all adjacent elements and obtain {12+13} = {25}.

class CondenseArrayToNumber
{
    static void Main()
    {
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        while (nums.Length >= 2)
        {
            int[] condensed = new int[nums.Length - 1];

            for (int i = 0; i < nums.Length - 1; i++)
            {
                condensed[i] = nums[i] + nums[i + 1];
            }

            nums = condensed;
        }

        Console.WriteLine(nums[0]);
    }
}

