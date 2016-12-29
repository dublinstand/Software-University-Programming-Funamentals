using System;
using System.Linq;

//Write a program to read an array of strings, reverse it and print its elements.
//The input consists of a sequence of space separated strings.
//Print the output on a single line (space separated).

class ReverseArrayОfStrings
{
    static void Main()
    {
        string[] arr = Console.ReadLine().Split(' ');
        string[] reversedArray = arr.Reverse().ToArray();

        Console.WriteLine(string.Join(" ", reversedArray));
    }
}

