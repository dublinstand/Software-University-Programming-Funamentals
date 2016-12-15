using System;

//Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values 
//by using some programming logic.Print the variable values before and after the exchange, as shown below:

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

