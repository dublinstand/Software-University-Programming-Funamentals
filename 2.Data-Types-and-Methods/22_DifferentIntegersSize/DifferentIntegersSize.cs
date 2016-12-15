using System;

//Given an input integer, you must determine which primitive data types are capable of properly storing that input.

class DifferentIntegersSize
{

    static void Main()
    {
        string value= Console.ReadLine();

        try
        {
            long number = long.Parse(value);
            Console.WriteLine("{0} can fit in:", number);
        }
        catch (Exception)
        {

            Console.WriteLine("{0} can't fit in any type", value);
        }

        try
        {
            sbyte number = sbyte.Parse(value);
            Console.WriteLine("* sbyte");
        }
        catch (OverflowException)
        {

        }

        try
        {
            byte number = byte.Parse(value);
            Console.WriteLine("* byte");
        }
        catch (OverflowException)
        {

        }

        try
        {
            short number = short.Parse(value);
            Console.WriteLine("* short");
        }
        catch (OverflowException)
        {

        }

        try
        {
            ushort number = ushort.Parse(value);
            Console.WriteLine("* ushort");
        }
        catch (OverflowException)
        {

        }

        try
        {
            int number = int.Parse(value);
            Console.WriteLine("* int");
        }
        catch (OverflowException)
        {

        }

        try
        {
            uint number = uint.Parse(value);
            Console.WriteLine("* uint");
        }
        catch (OverflowException)
        {

        }

        try
        {
            long number = long.Parse(value);
            Console.WriteLine("* long");
        }
        catch (OverflowException)
        {
            
        }

    }
}

