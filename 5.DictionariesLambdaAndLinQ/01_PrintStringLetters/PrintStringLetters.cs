using System;
using System.Collections.Generic;
using System.Linq;

//Read a string and print its letters as in the examples below.

class PrintStringLetters
{
    static void Main()
    {
        string word = Console.ReadLine();

        for (int i = 0; i < word.Length; i++)
        {
            Console.WriteLine($"str[{i}] -> '{word[i]}'");
        }

    }
}

