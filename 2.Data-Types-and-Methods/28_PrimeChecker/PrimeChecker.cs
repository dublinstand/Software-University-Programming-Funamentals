using System;

class PrimeChecker
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        Console.WriteLine(isPrime(n));
    }

    private static bool isPrime(long n)
    {
        bool isPrime = true;

        if (n <= 1)
        {
            isPrime = false;
            return isPrime;
        }
        
        for (int i = 2; i <= (int)Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                isPrime = false;
                break;
            }            
        }

        return isPrime;
    }
}

