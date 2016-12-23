using System;
using System.Collections.Generic;

class PrimesInGivenRange
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        List<int> primeNumbers = FindPrimesInRange(a, b);

        string numbers = String.Join(", ", primeNumbers.ToArray());
        Console.WriteLine(numbers);

        //foreach(int i in primeNumbers)
        //{
        //    Console.Write($"{i}, ");          

        //}
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

    private static List<int> FindPrimesInRange(int startNum, int endNum)
    {
        List<int> numbers = new List<int>();

        for (int i = startNum; i <= endNum; i++)
        {
            
            if (isPrime(i))
            {
                numbers.Add(i);
            }
        }

        return numbers;
    }
}




