using System;
using System.Collections.Generic;
using System.Linq;

//Read a text, split it into words and distribute them into 3 lists.
//	Lower-case words like “programming”, “at” and “databases” – consist of lowercase letters only.
//	Upper-case words like “PHP”, “JS” and “SQL” – consist of uppercase letters only.
//	Mixed-case words like “C#”, “SoftUni” and “Java” – all others.
//Use the following separators between the words: , ; : . ! ( ) " ' \ / [ ] space

class SumAdjacentEqualNumbers
{
    static void Main()
    {
        char[] separators = new char[] { ',', ';', ':', '.', '!', ' ', '(', ')', '"', '\'', '/', '\\', '[', ']' };

        List<string> words = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();

        List<string> lowerCaseWords = new List<string>();
        List<string> mixedCaseWords = new List<string>();
        List<string> upperCaseWords = new List<string>();

        foreach(string word in words)
        {
            WordType type = GetWordType(word);

            if (type == WordType.UpperCase)
            {
                upperCaseWords.Add(word);
            }
            else if (type == WordType.MixedCase)
            {
                mixedCaseWords.Add(word);
            }
            else if(type == WordType.LowerCase)
            {
                lowerCaseWords.Add(word);
            }
        }

        Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCaseWords));
        Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCaseWords));
        Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCaseWords));

    }

    enum WordType { UpperCase, MixedCase, LowerCase };

    static WordType GetWordType(string word)
    {
        int lowerCaseCount = 0;
        int upperCaseCount = 0;

        foreach (char let in word)
        {
            if (char.IsLower(let))
            {
                lowerCaseCount++;
            }
            else if (char.IsUpper(let))
            {
                upperCaseCount++;
            }
        }

        if (lowerCaseCount == word.Count())
        {
            return WordType.LowerCase;
        }
        else if (upperCaseCount == word.Count())
        {
            return WordType.UpperCase;
        }
        else
        {
            return WordType.MixedCase;
        }
    } 
}