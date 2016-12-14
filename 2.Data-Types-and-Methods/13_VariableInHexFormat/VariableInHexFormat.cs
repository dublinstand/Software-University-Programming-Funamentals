using System;

class VariableInHexFormat
{
    static void Main()
    {
        string hex = Console.ReadLine();

        int convertedHex = Convert.ToInt32(hex, 16);

        Console.WriteLine(convertedHex);
    }
}

