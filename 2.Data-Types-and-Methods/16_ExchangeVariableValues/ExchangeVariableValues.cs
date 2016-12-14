using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int c;
        Console.WriteLine($"Before: \r\na = {a}\r\nb = {b}");

        c = a;
        a = b;
        b = c;
        Console.WriteLine("After: \r\na = {0}\r\nb = {1}", a, b);        
    }
}

