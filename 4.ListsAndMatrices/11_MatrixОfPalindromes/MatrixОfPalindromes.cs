using System;
using System.Collections.Generic;
using System.Linq;

//Write a program to generate the following matrix of palindromes of 3 letters with r rows and c columns like at the examples below.
//•	Rows define the first and the last letter: row 0  ‘a’, row 1  ‘b’, row 2  ‘c’, …
//•	Columns + rows define the middle letter: 
//o column 0, row 0  ‘a’, column 1, row 0  ‘b’, column 2, row 0  ‘c’, …
//o column 0, row 1  ‘b’, column 1, row 1  ‘c’, column 2, row 1  ‘d’, …
//o   …
//Input
//•	The number r and c stay at the first line at the input.
//•	Constraints: r and c are integers in the range [1…26]; r + c ≤ 27.


class MatrixОfPalindromes
{
    static void Main()
    {
        int row = int.Parse(Console.ReadLine());
        int column = int.Parse(Console.ReadLine());

        char firstLetter = 'a';

        for (int i = 0; i < row; i++)
        {
            char middleLetter = firstLetter;

            for (int j = 0; j < column; j++)
            {
                Console.Write("" + firstLetter + middleLetter + firstLetter + " ");
                middleLetter++;
            }
            Console.WriteLine();
            firstLetter++;
        }

    }
}

