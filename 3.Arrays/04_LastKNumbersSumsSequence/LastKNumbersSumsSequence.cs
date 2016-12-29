using System;

//Enter two integers n and k.Generate and print the following sequence of n elements:
//•	The first element is: 1
//•	All other elements = sum of the previous k elements (if less than k are available, sum all of them)
//•	Example: n = 9, k = 5  120 = 4 + 8 + 16 + 31 + 61


class LastKNumbersSumsSequence
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        arr[0] = 1;

        for (int i = 1; i < n; i++)
        {
            arr[i] = SumNums(arr, i - k, i - 1);
        }

        Console.WriteLine(string.Join(" ", arr));

    }

    private static int SumNums(int[] arr, int startNum, int endNum)
    {
        int sum = 0;

        for (int i = startNum; i <= endNum; i++)
        {
            if (i >= 0)
            {
                sum += arr[i];
            }
        }

        return sum;
    }
}

