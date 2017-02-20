using System;
using System.Collections.Generic;
using System.Linq;

//Write a program that reads sequence of numbers, reverses their digits, and prints their sum.


class SumReversedNumbers
{
    static void Main()
    {
        string[] nums = Console.ReadLine().Split();

        List<int> revNums = reverseAllNums(nums);
        //Console.WriteLine(string.Join(", ", revNums));

        int sum = sumNums(revNums);
        Console.WriteLine(sum);

    }

    private static int sumNums(List<int> revNums)
    {
        int sum = 0;

        foreach (int num in revNums)
        {
            sum += num;
        }

        return sum;
    }

    private static List<int> reverseAllNums(string[] nums)
    {
        List<int> newNums = new List<int>();

        foreach (string num in nums)
        {
            string temp = "";
            for (int i = num.Length - 1; i >= 0; i--)
            {
                temp += num[i];
            }

            newNums.Add(int.Parse(temp));
        }
        return newNums;
    }
}

