using System;

//Write a program to ask the user for 3 letters and print them in reversed order.

class ReversedChars
{
    static void Main()
    {
        char l1 = char.Parse(Console.ReadLine());
        char l2 = char.Parse(Console.ReadLine());
        char l3 = char.Parse(Console.ReadLine());

        Console.WriteLine($"{l3}{l2}{l1}");
    }
}

