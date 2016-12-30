using System;
using System.Linq;

//Read two arrays of words and find the length of the largest common end(left or right).

class LargestCommonEnd
{
    static void Main()
    {
        string[] arr1 = Console.ReadLine().Split(' ').ToArray();
        string[] arr2 = Console.ReadLine().Split(' ').ToArray();

        int minLength = Math.Min(arr1.Length, arr2.Length);

        int count = 0;


        if (arr1[0] == arr2[0])
        {
            for (int i = 0; i < minLength; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    count++;
                }
            }
        }
        else if (arr1.Last() == arr2.Last())
        {
            string[] arr1Reversed = arr1.Reverse().ToArray();
            string[] arr2Reversed = arr2.Reverse().ToArray();

            for (int i = 0; i < minLength; i++)
            {
                if (arr1Reversed[i] == arr2Reversed[i])
                {
                    count++;
                }
            }
        }       

        Console.WriteLine(count);

    }
}

