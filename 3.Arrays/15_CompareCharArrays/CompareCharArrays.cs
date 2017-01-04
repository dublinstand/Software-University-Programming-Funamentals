using System;
using System.Linq;

//Compare two char arrays lexicographically(letter by letter).
//Print the them in alphabetical order, each on separate line.


class CompareCharArrays
{
    static void Main()
    {
        char[] charOne = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
        char[] charTwo = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

        int charOneLength = charOne.Length;
        int charTwoLength = charTwo.Length;

        int minLength = Math.Min(charOneLength, charTwoLength);

        Boolean areEqual = true;

        for (int i = 0; i < minLength; i++)
        {
            if (charOne[i] == charTwo[i])
            {
                continue;
            }
            else
            {
                if (charOne[i] < charTwo[i])
                {
                    printArrays(charOne, charTwo);
                    return;

                }
                else
                {
                    printArrays(charTwo, charOne);
                    return;
                }                                   
            }
        }

        if (areEqual)
        {
            if (charOne.Length > charTwo.Length)
            {
                printArrays(charTwo, charOne);
            }
            else
            {
                printArrays(charOne, charTwo);
            }
        }
    }

    private static void printArrays(char[] charFirst, char[] charSecond)
    {
        Console.WriteLine(charFirst);
        Console.WriteLine(charSecond);
    }
}

