using System;
using System.Linq;

//Write a program that reads two arrays of integers and sums them.
//When the arrays are not of the same size, duplicate the smaller array a few times.

class SumArrays
{
    static void Main()
    {
        int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int n = Math.Max(arr1.Length, arr2.Length);

        int[] arrSum = new int[n];

        for (int i = 0; i < n; i++)
        {
            arrSum[i] = arr1[i % arr1.Length] + arr2[i % arr2.Length];
        }

        Console.WriteLine(string.Join(" ", arrSum));

    }
}

