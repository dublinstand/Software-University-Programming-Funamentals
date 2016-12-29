using System;
using System.Linq;

//Write a program to read an array of real numbers(space separated values), round them to the nearest integer in “away from 0” style and print the output as in the examples below.
//Rounding in “away from zero” style means:
//•	To round to the nearest integer, e.g. 2.9  3; -1.75  -2


class RoundingNumbersAwayFromZero
{
    static void Main()
    {
        double[] arr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine($"{arr[i]} => {Math.Round(arr[i], MidpointRounding.AwayFromZero)}");
        }

    }
}

