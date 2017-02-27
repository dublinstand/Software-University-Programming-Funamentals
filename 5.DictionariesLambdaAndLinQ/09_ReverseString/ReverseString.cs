using System;
using System.Collections.Generic;

//Write a program that reads a string from the console, reverses its letters and prints the result back at the console.


class ReverseString
{
    static void Main()
    {
        string word = Console.ReadLine();

        for (int i = word.Length - 1; i >= 0; i--)
        {
            Console.Write(word[i]);
        }
        Console.WriteLine();
    }
}

