using System;

//A number is special when its sum of digits is 5, 7 or 11.
//Write a program to read an integer n and for all numbers in the range 1…n to print the number and if it is special or not(True / False).


class SpecialNumbers
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            int num2 = i;
            int sum = 0;

            while (num2 != 0)
            {
                sum += num2 % 10;
                num2 = num2 / 10;

            }

            bool special = (sum == 5 || sum == 7 || sum == 11);
            Console.WriteLine("{0} -> {1}", i, special);

            //if (sum == 5 || sum == 7 || sum == 11)
            //{
            //    Console.WriteLine("{0} -> True", i);
            //}
            //else
            //{
            //    Console.WriteLine("{0} -> False", i);
            //}
        }
    }
}

