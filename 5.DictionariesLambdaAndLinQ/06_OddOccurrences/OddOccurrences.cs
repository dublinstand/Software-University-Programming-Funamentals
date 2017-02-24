using System;
using System.Collections.Generic;
using System.Linq;

//Write a program that extracts from a given sequence of words all elements that present in it odd number of times(case-insensitive).
//•	Words are given in a single line, space separated.
//•	Print the result elements in lowercase, in their order of appearance.


class OddOccurrences
{
    static void Main()
    {

        string token = Console.ReadLine().ToLower();
        string[] words = token.Split(' ');

        Dictionary<string, int> dict = new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (dict.ContainsKey(word))
            {
                dict[word]++;
            }
            else
            {
                dict[word] = 1;
            }
        }

        List<string> oddNumsOfWords = new List<string>();

        foreach (var item in dict)
        {
            if (item.Value % 2 == 1)
            {
                oddNumsOfWords.Add(item.Key);
            }
        }

        Console.WriteLine(string.Join(", ", oddNumsOfWords));

    }
}

