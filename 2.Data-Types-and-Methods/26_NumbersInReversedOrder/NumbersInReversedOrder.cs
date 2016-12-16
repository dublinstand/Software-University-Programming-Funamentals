using System;

//Write a method that prints the digits of a given decimal number in a reversed order.

class NumbersInReversedOrder
{
    static void Main()
    {
        string number = Console.ReadLine();
        reverseNum(number);        
    }

    static void reverseNum (string number)
    {
        for (int i = number.Length - 1; i >= 0; i--)
        {
            Console.Write(number[i]);
        }
    }
}

