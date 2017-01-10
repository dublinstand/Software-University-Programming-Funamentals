using System;
using System.Linq;

//Write a program that count the number of pairs in given array which difference is equal to given number.

class PairsByDifference
{
    static void Main()
    {
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int difference = int.Parse(Console.ReadLine());
        int count = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[i] - nums[j] == difference)
                {
                    count++;
                }
            }            
        }

        Console.WriteLine(count);
    }
}

