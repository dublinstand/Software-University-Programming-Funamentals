using System;
using System.Collections.Generic;
using System.Linq;

//Read a text and several forbidden words.Replace all forbidden words with stars(e.g.beer -> ****). 
//Use "substring" matching(match part of word), case-sensitive.Use the same number of stars like the word length.

class ForbiddenSubstrings
{
    static void Main()
    {
        string text = Console.ReadLine();
        string[] words = Console.ReadLine().Split(' ');

        foreach (string word in words)
        {
            text = text.Replace(word, new string('*', word.Length));
        }

        Console.WriteLine(text);

    }
}

