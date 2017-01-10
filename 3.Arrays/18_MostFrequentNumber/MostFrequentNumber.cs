using System;
using System.Linq;

//Write a program that finds the most frequent number in a given sequence of numbers.
//•	Numbers will be in the range[0…65535].
//•	In case of multiple numbers with the same maximal frequency, print the leftmost of them.


class MostFrequentNumber
{
    static void Main()
    {
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] distinctNumbers = nums.Distinct().ToArray();    //returns all unique elements of the array. In this case numbers
        int count = 0;
        int num = 0;
        int maxCount = 0;
        int maxNum = 0;

        for (int i = 0; i < distinctNumbers.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (distinctNumbers[i] == nums[j])
                {
                    count++;
                    num = distinctNumbers[i];
                }
            }

            if (count > maxCount)
            {
                maxCount = count;
                maxNum = num;
            }
            

            count = 0;
        }

        Console.WriteLine(maxNum);
    }
}

