using System;
using System.Collections.Generic;
using System.Linq;

//Write a program, which reads a rectangular matrix of integers of size of r rows by c columns.
//    Find in the matrix a platform of size 3 x 3 with a maximal sum.

class MaxPlatform3x3
{
    static void Main()
    {
        int[] token = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int rows = token[0];
        int cols = token[1];

        int[][] matrix = new int[rows][];

        int sum = 0;
        int currentSum = 0;
        int bestRow = 0;
        int bestCol = 0;

        for (int i = 0; i < rows; i++)
        {
            matrix[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
        }

        for (int i = 0; i < rows - 2; i++)
        {
            for (int j = 0; j < cols - 2; j++)
            {
                currentSum = matrix[i][j] + matrix[i][j + 1] + matrix[i][j + 2] +
                    matrix[i + 1][j] + matrix[i + 1][j + 1] + matrix[i + 1][j + 2] + 
                    matrix[i + 2][j] + matrix[i + 2][j + 1] + matrix[i + 2][j + 2];

                if (sum < currentSum)
                {
                    sum = currentSum;
                    bestRow = i;
                    bestCol = j;
                }
            }

        }        

        Console.WriteLine(sum);

        for (int i = bestRow; i < bestRow + 3; i++)
        {
            for (int j = bestCol; j < bestCol + 3; j++)
            {
                Console.Write(matrix[i][j] + " ");
            }
            Console.WriteLine();
        }

    }
}

