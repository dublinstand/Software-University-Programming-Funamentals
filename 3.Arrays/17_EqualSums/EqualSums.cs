using System;
using System.Linq;

//Write a program that determines if there exists an element in the array such that the sum of the elements on its left is equal to the sum of the elements on 
//    its right.If there are no elements to the left / right, their sum is considered to be 0. Print the index that satisfies the required condition or “no” 
//        if there is no such index.

class EqualSums
{
    static void Main()
    {
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int length = nums.Length;
        int sumLeft = 0;
        int sumRight = 0;

        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < i; j++)
            {
                sumLeft += nums[j];
            }

            for (int k = i + 1; k < length; k++)
            {
                sumRight += nums[k];
            }

            if (sumLeft == sumRight)
            {
                Console.WriteLine(i);
                return;
            }

            if (i < length - 1)
            {
                sumLeft = 0;
                sumRight = 0;
            }
        }

        if (sumLeft != 0)
        {
            Console.WriteLine("no");

        }
        else
        {
            Console.WriteLine("0");
        }

    }
}
