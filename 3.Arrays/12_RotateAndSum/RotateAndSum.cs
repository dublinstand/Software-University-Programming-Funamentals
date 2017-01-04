using System;
using System.Linq;

//To “rotate an array on the right” means to move its last element first: {1, 2, 3}  {3, 1, 2}.
//Write a program to read an array of n integers(space separated on a single line) and an integer k, 
//rotate the array right k times and sum the obtained arrays after each rotation as shown below.


class RotateAndSum
{
    static void Main()
    {
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int k = int.Parse(Console.ReadLine());

        int length = nums.Length;

        int[] sum = new int[length];

        for (int i = 0; i < k; i++)
        {
            int lastNum = nums[length - 1];             //the last number from the array will be stored to be put as 0 element

            for (int j = length - 1; j > 0; j--)
            {
                nums[j] = nums[j - 1];                  //rotate the array with one right
            }
            nums[0] = lastNum;

            //Console.WriteLine(string.Join(" ", nums));    // to check if it is rotated correctly
            for (int l = 0; l < length; l++)
            {
                sum[l] += nums[l];
            }
        }

        Console.WriteLine(string.Join(" ", sum));
    }
}

