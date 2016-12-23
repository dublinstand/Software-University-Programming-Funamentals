using System;

//Define a method Fib(n) that calculates the nth Fibonacci number.Examples:

class FibonacciNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        fib(n);
    }

    private static void fib(int n)
    {
        int a = 1;
        int b = 1;
        int sum = 0;
        if (n == 1 || n == 0)
        {
            Console.WriteLine("1");
        }
        else
        {
            for (int i = 0; i < n - 1; i++)
            {
                sum = a + b;
                b = a;
                a = sum;
            }

            Console.WriteLine(sum);
        }
        
    }
}

