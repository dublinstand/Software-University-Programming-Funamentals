using System;

//Write a program that reads a string, converts it to Boolean variable and prints “Yes” if the variable is true and “No” 
//if the variable is false.

class BooleanVariable
{
    static void Main()
    {
        string boolean = Console.ReadLine();
        bool convertedBoolean = Convert.ToBoolean(boolean);

        if (convertedBoolean)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

