using System;
using System.Collections.Generic;
using System.Linq;

//Read a list of integers and extract all square numbers from it and print them in descending order.
//A square number is an integer which is the square of any integer.For example, 1, 4, 9, 16 are square numbers.

class SquareNumbers
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        List<int> squareNumbers = new List<int>();

        foreach(int num in numbers)
        {
            if (isSquareCorrect(num))
            {
                squareNumbers.Add(num);
            }
        }

        squareNumbers.Sort((a, b) => b.CompareTo(a));

        Console.WriteLine(string.Join(" ", squareNumbers));
    }

    static Boolean isSquareCorrect(int number)
    {
        double squareNumber = Math.Sqrt(number);

        if (squareNumber == (int) squareNumber)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

