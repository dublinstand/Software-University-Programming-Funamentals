using System;

class CircleArea
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());
        double s = Math.PI * r * r;
        Console.WriteLine("{0:f12}", s);
    }
}

