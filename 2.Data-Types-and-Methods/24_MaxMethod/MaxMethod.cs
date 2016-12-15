using System;

//Create a method GetMax(int a, int b), that returns maximal of the two numbers.
//Write a program that reads three numbers from the console and prints the biggest of them.Use the GetMax(…) method you just created.

class MaxMethod
{
    static void Main()
    {
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());
        int f = int.Parse(Console.ReadLine());

        int g = getMax(d, e);
        int h = getMax(g, f);
        Console.WriteLine(h);
    }

    static int getMax(int a, int b)
    {
        int c = Math.Max(a, b);
        return c;
    }
}

