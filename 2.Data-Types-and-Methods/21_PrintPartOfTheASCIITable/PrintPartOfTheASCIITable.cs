using System;

//write a program to prints part of the ASCII table of characters at the console.
//On the first line of input you will receive the char index you should start with and 
//on the second line - the index of the last character you should print.

class PrintPartOfTheASCIITable
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        for (int i = a; i <= b; i++)
        {
            Console.Write((char)i + " ");
        }
    }
}

