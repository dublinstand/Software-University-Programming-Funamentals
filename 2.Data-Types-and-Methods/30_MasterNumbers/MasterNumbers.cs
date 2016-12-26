using System;
using System.Collections.Generic;
using System.Linq;

//A master number is an integer that holds the following properties:
//•	Is symmetric(palindrome), e.g. 5, 77, 282, 14341, 9553559.
//•	Its sum of digits is divisible by 7, e.g. 77, 313, 464, 5225, 37173.
//•	Holds at least one even digit, e.g. 232, 707, 6886, 87578.
//Write a program to print all master numbers in the range[1…n].


class MasterNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            if (IsPalindrome(i) && isSumOfDigitsDividedBy7(i) && ContainsEvenDigit(i))
            {
                Console.WriteLine(i);
            }
        }
    }

    static bool IsPalindrome(int num)
    {
        bool isPalindrome = false;
        String number = num.ToString();
        string reversedNum = string.Join("", number.ToCharArray().Reverse().ToArray());        //number becomes a CharArray, then use Reverse and put it as a string

        if (number == reversedNum)
        {
            isPalindrome = true;
        }

        return isPalindrome;
    }

    static bool isSumOfDigitsDividedBy7(int num)
    {
        int sum = 0;
        //String number = num.ToString();

        //for (int i = 0; i < number.Length -1; i++)
        //{
        //    sum += (int)number[i];
        //}

        while (num > 0)
        {
            sum += num % 10;
            num = num / 10;
        }

        if (sum % 7 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static bool ContainsEvenDigit(int num)
    {
        bool containsEvenDigit = false;

        while (num > 0)
        {
            int lastDigit = num % 10;
            if (lastDigit % 2 == 0)
            {
                containsEvenDigit = true;
                break;
            }
            num = num / 10;
        }

        //String number = num.ToString();

        //for (int i = 0; i < number.Length - 1; i++)
        //{
        //    if ((int)number[i] % 2 == 0)
        //    {
        //        containsEvenDigit = true;
        //    }
        //}

        return containsEvenDigit;
    }


}

