﻿using System;

//Write program to enter n numbers and calculate and print their exact sum(without rounding).

class ExactSumOfRealNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        decimal sum = 0;
        for (int i = 0; i < n; i++)
        {
            decimal num = decimal.Parse(Console.ReadLine());
            sum += num;
        }

        Console.WriteLine(sum);
    }
}

