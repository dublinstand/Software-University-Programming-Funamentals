using System;
using System.Linq;

//Write a program to read n integers and print their sum, min, max, first, last and average values.

class SumMinMaxFirstLastAverage
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int max = arr.Max();
        int min = arr.Min();
        int sum = arr.Sum();
        int first = arr.First();
        int last = arr.Last();
        double average = arr.Average();

        Console.WriteLine("Sum = {0}", sum);
        Console.WriteLine($"Min = {min}");
        Console.WriteLine($"Max = {max}");
        Console.WriteLine($"First = {first}");
        Console.WriteLine($"Last = {last}");
        Console.WriteLine($"Average = {average}");
    }
}