using System;
using System.Collections.Generic;
using System.Linq;

//Read two strings text and substr and count how many times substr occurs in the text as substring, case-insensitive.
//The input holds two text lines: the text and the substring.The output consists of an integer number.

class OccurrencesInString
{
    static void Main()
    {
        string text = Console.ReadLine();
        string part = Console.ReadLine();
        int count = 0;
        int offset = -1;

        while (true)
        {
            offset = text.IndexOf(part, offset + 1);
            if (offset == -1)
            {
                break;
            }
            count++;
        }

        Console.WriteLine(count);



    }
}

