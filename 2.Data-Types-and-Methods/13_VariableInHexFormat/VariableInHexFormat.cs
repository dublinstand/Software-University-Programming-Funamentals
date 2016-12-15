using System;

//Write a program that reads a number in hexadecimal format(0x##) convert it to decimal format and prints it.

class VariableInHexFormat
{
    static void Main()
    {
        string hex = Console.ReadLine();

        int convertedHex = Convert.ToInt32(hex, 16);

        Console.WriteLine(convertedHex);
    }
}

