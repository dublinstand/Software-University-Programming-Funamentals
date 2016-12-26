using System;

//Write a Boolean method IsPrime(n) that check whether a given integer number n is prime.

class PrimeChecker
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        Console.WriteLine(isPrime(n));
    }

    private static bool isPrime(long n)
    {
        if (n <= 1)
        {
            return false;
        }
        
        for (int i = 2; i <= (int)Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                return false;
            }            
        }

        return true;
    }
}

