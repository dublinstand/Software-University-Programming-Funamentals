using System;
using System.Numerics;

//Calculate and print n! (n factorial) for very big integer n(e.g. 1000).

class BigFactorial
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        Console.WriteLine(factorial);

    }
}

