using System;
using System.Linq;

//Write a method to extract the middle 1, 2 or 3 elements from array of n integers and print them.
//•	n = 1 -> 1 element
//•	even n -> 2 elements
//•	odd n -> 3 elements
//Create a program that reads an array of integers(space separated values) and prints the middle elements in the format shown in the examples.


class ExtractMiddleElements
{
    static void Main()
    {
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int[] result = ExtractMiddleNumbers(nums);

        Console.WriteLine("{ " + string.Join(" ", result) + " }");
    }

    private static int[] ExtractMiddleNumbers(int[] nums)
    {
        int len = nums.Length;

        if (len == 1)
        {
            return nums;
        }

        if (len % 2 == 0)
        {
            return new int[] { nums[len / 2 - 1], nums[len / 2] };
        }
        else
        {
            return new int[] { nums[len / 2 - 1], nums[len / 2], nums[len / 2 + 1] };
        }
    }
}

