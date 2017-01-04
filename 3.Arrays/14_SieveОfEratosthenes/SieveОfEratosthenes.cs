using System;
using System.Linq;

//Write a program to find all prime numbers in range[1…n]. Implement the algorithm called “Sieve of Eratosthenes”: https://en.wikipedia.org/wiki/Sieve_of_Eratosthenes. Steps in the “Sieve of Eratosthenes” algorithm:
//1.	Assign primes[0…n] = true
//2.	Assign primes[0] = primes[1] = false
//3.	Find the smallest p, which holds primes[p] = true
//•	Print p(it is prime)
//•	Assign primes[2 * p] = primes[3 * p] = primes[4 * p] = … = false
//4.	Repeat for the next smallest p<n.


class SieveОfEratosthenes
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] nums = new int[n + 1];
        bool[] bools = new bool[n + 1];

        string primeNums = null;

        for (int i = 0; i < n; i++)
        {
            nums[i] = i;
            bools[i] = true;
        }

        primeNums = SieveOfErat(nums, bools, primeNums);

        Console.WriteLine(primeNums.Trim());

    }

    private static string SieveOfErat(int[] nums, bool[] bools, string primeNums)
    {
        bools[0] = false;
        bools[1] = false;

        for (int i = 0; i < nums.Length; i++)
        {
            if (bools[i])
            {
                primeNums = $"{primeNums}{nums[i]} ";

                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] % i == 0 && bools[j] == true)
                    {
                        bools[j] = false;
                    }

                }
            }
        }

        return primeNums;
    }

    //static bool isPrime(int num)
    //{
    //    bool isPrime = false;
    //    for (int i = 2; i <= num; i++)
    //    {
    //        if (num % i == 0)
    //        {
    //            isPrime = true;
    //            return isPrime;
    //        }
    //    }

    //    return isPrime;
    //}
}

