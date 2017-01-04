using System;
using System.Linq;

//Read two arrays of words and find the length of the largest common end(left or right).

class LargestCommonEndSecondSolution
{
    static void Main()
    {
        string[] arr1 = Console.ReadLine().Split(' ').ToArray();
        string[] arr2 = Console.ReadLine().Split(' ').ToArray();

        int minLength = Math.Min(arr1.Length, arr2.Length);

        int leftCount = 0;
        int rightCount = 0;

        for (int i = 0; i < minLength; i++)
        {
            if (arr1[i] == arr2[i])
            {
                leftCount++;
            }
            else
            {
                break;
            }
        }

        for (int i = 0; i < minLength; i++)
        {
            if (arr1[arr1.Length - 1 - i] == arr2[arr2.Length - 1 -i])
            {
                rightCount++;
            }
            else
            {
                break;
            }
        }

        Console.WriteLine(Math.Max(leftCount, rightCount));
    }
}

