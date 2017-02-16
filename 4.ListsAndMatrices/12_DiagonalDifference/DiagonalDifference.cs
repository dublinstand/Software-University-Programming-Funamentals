using System;
using System.Collections.Generic;
using System.Linq;

//Write a program that finds the difference between the sums of the square matrix diagonals(absolute value).

class DiagonalDifference
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int[][] matrix = new int[size][];

        int primaryDiagonal = 0;
        int secondaryDiagonal = 0;

        for (int i = 0; i < size; i++)
        {
            matrix[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        }

        for (int row = 0; row < size; row++)
        {

            for (int col = 0; col < size; col++)
            {
                if (row == col)
                {
                    primaryDiagonal += matrix[row][col];
                }

                if (col == size - 1 - row)
                {
                    secondaryDiagonal += matrix[row][col];
                }
            }
        }

        int difference = Math.Abs(primaryDiagonal - secondaryDiagonal);
        Console.WriteLine(difference);

    }
}

