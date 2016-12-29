using System;
using System.Linq;

//Write a program to read an array of integers, reverse it and print its elements.
//The input consists of a number n (the number of elements) + n integers, each as a separate line.Print the output on a single line(space separated).

class ReverseArrayOfIntegers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = numbers.Length - 1 ; i >= 0; i--)
        {
            Console.Write(numbers[i] + " ");

        }

        //int[] reverse = numbers.Reverse().ToArray();
        //Console.WriteLine(string.Join(" ", reverse));

        Console.WriteLine();
    }
}

