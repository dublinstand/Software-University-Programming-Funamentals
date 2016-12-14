using System;

class StringsAndObjects
{
    static void Main()
    {
        string firstWord = "Hello";
        string SecondWord = "World";
        object varConcat1 = firstWord + " " + SecondWord;
        string varConcat2 = (string)varConcat1;
        Console.WriteLine("{0}", varConcat2);
    }
}

