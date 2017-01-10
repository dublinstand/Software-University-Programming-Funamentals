using System;
using System.Linq;

//Write a program that finds the longest sequence of equal elements in an array of integers.If several longest sequences exist,
//print the leftmost one.

class MaxSequenceОfEqualElements
{
    static void Main()
    {
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int length = nums.Length;
       

        int maxNumbers = 0;
        int count = 1;
        int maxCount = 1;
        int pos = 0;
        int cnt = nums.Count();

        while (pos < length - 1)
        {
            if (nums[pos] == nums[pos + 1])
            {
                count++;

                if (count > maxCount)
                {
                    maxCount = count;
                    maxNumbers = nums[pos];
                }
            }
            else
            {
                count = 1;
            }

            pos++;

            if (maxCount == 1)
            {
                maxNumbers = nums[0];
            }

        }

        for (int i = 0; i < maxCount; i++)
        {
            Console.Write(maxNumbers + " ");
        }

    }
}
