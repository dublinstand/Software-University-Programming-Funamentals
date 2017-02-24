using System;
using System.Collections.Generic;
using System.Linq;

//Read a text, extract its words, find all short words(less than 5 characters) and print them alphabetically, in lowercase.
//•	Use the following separators: . , : ; ( ) [ ] " ' \ / ! ? (space).
//•	Use case-insensitive matching.
//•	Remove duplicated words.


class ShortWordsSorted
{
    static void Main()
    {
        char[] separators = ".,:;()[]\"'\\/!? ".ToCharArray();
        string[] words = Console.ReadLine().ToLower().Split(separators);

        var result = words.Where(x => x.Length < 5 && x != "").OrderBy(x => x).Distinct();

        Console.WriteLine(string.Join(", ", result));


    }
}

