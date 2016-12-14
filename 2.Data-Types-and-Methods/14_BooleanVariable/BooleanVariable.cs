using System;

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

