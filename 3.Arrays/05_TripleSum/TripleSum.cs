using System;
using System.Linq;

//Write a program to read an array of integers and find all triples of elements a, b and c, 
//such that a + b == c(where a stays left from b). Print “No” if no such triples exist.

class TripleSum
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int count = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
               int a = arr[i];
               int b = arr[j];
               int sum = a + b;

                if (arr.Contains(sum))
                {
                    Console.WriteLine($"{a} + {b} == {sum}");
                    count++;
                }
            }
        }

        if (count == 0)
        {
            Console.WriteLine("No");
        }
    }
}

