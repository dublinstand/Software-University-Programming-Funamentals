﻿using System;
using System.Collections.Generic;
using System.Linq;

//Write a program to read a matrix of words(space separated) and rotate it on the right as shown in the examples.


class RotateMatrix
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());

        string[][] matrix = new string[rows][];

        for (int row = 0; row < rows; row++)
        {
            matrix[row] = Console.ReadLine().Split(' ');
        }

        for (int col = 0; col < cols; col++)
        {
            for (int row = rows - 1; row >= 0 ; row--)
            {
                Console.Write(matrix[row][col] + " ");
            }
            Console.WriteLine();
        }
    }

}
