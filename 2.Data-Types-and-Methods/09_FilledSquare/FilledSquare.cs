using System;

class FilledSquare
{
    
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        printHeaderRow(n);

        for (int i = 0; i < n - 1; i++)
        {
            printMiddleRows(n);
        }

        printHeaderRow(n);
    }

    static void printHeaderRow(int n)
    {
        Console.WriteLine(new string('-', 2 * n));
    }

    static void printMiddleRows(int n)
    {
        Console.Write("-");
        for (int i = 0; i < n - 1; i++)
        {
            Console.Write(@"\/");
        }
        Console.WriteLine("-");
    }
}

