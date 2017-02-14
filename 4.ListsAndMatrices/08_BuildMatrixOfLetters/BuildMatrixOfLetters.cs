using System;
using System.Collections.Generic;
using System.Linq;

//Build and print a matrix of capital Latin letters of size rows x cols like at the example below.

class BuildMatrixOfLetters
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());

        //first we set up the rows and in the for loop we set up for each row number of cols
        char[][] matrix = new char[rows][];
        char letter = 'A';

        for (int row = 0; row < rows; row++)
        {
            //first we set up the rows and in the for loop we set up for each row number of cols
            matrix[row] = new char[cols];

            for (int col = 0; col < cols; col++)
            {
                matrix[row][col] = letter;
                letter++;
            }            
        }

        for (int row = 0; row < rows; row++)
        {
            Console.WriteLine(string.Join(" ", matrix[row]));
        }
    }
}

