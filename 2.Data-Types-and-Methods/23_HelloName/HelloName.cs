using System;

//Write a method that receives a name as parameter and prints on the console. “Hello, <name>!”

class HelloName
{
    static void Main()
    {
        string name = Console.ReadLine();
        printName(name);
    }

    static void printName(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }
}

