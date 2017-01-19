using System;
using System.Linq;
using System.Numerics;

class BigFactorial
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger factorial = 1;

        for (int i = 0; i <= n; i++)
        {
            factorial *= n;
        }

        Console.WriteLine(factorial);

    }
}

