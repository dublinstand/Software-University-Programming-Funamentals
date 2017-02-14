using System;
using System.Collections.Generic;
using System.Linq;

//Read a list of decimal numbers and sort them in increasing order.Print the output as shown in the examples below.

class SortNumbers
{
    static void Main()
    {
        List<double> decimalList = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
        decimalList.Sort();
        Console.WriteLine(string.Join(" <= ", decimalList));
    }
}

