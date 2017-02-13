using System;
using System.Collections.Generic;
using System.Linq;

//Write a program to sum all adjacent equal numbers in a list of decimal numbers, starting from left to right.
//	After two numbers are summed, the obtained result could be equal to some of its neighbors and should be summed as well (see the examples below).
//	Always sum the leftmost two equal neighbors(if several couples of equal neighbors are available).


class SumAdjacentEqualNumbers
{
    static void Main()
    {
        List<double> numbersList = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

        for (int i = 0; i < numbersList.Count - 1; i++)
        {
            if (numbersList[i] == numbersList[i + 1] && i != numbersList.Count - 1)
            {
                numbersList[i] = numbersList[i] + numbersList[i + 1];
                numbersList.RemoveAt(i + 1);
                i = -1;
            }
        }

        Console.WriteLine(string.Join(" ", numbersList));
    }
}

