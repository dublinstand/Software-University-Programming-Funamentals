using System;

//Create a program to check if given symbol is digit, vowel or any other symbol.

class VowelОrDigit
{
    static void Main()
    {
        char n = char.Parse(Console.ReadLine());

        if (n == 'a' || n == 'e' || n == 'y' || n == 'u' || n ==  'i' || n == 'o')
        {
            Console.WriteLine("vowel");
        }
        else if (char.IsDigit(n))
        {
            Console.WriteLine("digit");
        }
        else
        {
            Console.WriteLine("other");
        }
         
    }
}

