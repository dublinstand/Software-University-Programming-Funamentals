using System;
using System.Linq;

//Read an array of 4* k integers, fold it like shown below, 
//    and print the sum of the upper and lower two rows(each holding 2 * k integers):


class FoldAndSum
{
    static void Main()
    {
        int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int length = array.Length;
        int k = array.Length / 4;

        int[] firstElement = new int[k];
        int[] lastElement = new int[k];

        int[] middleRow = new int[2 * k];


        for (int i = 0; i < 2 * k; i++)
        {
            middleRow[i] = array[k + i];
        }

        for (int i = 0; i < k; i++)
        {
            firstElement[i] = array[i];
        }

        for (int i = 0; i < k ; i++)
        {
            lastElement[i] = array[3 * k + i];
        }

        Array.Reverse(firstElement);
        Array.Reverse(lastElement);

        int[] firstAndLastElement = new int[2 * k];

        for (int i = 0; i < firstAndLastElement.Length; i++)
        {
            if (i < k)
            {
                firstAndLastElement[i] = firstElement[i];
            }
            else
            {
                firstAndLastElement[i] = lastElement[i - k];
            }
        }

        for (int i = 0; i < middleRow.Length; i++)
        {
            middleRow[i] += firstAndLastElement[i];
        }

        Console.WriteLine(string.Join(" ", middleRow));

    }
}

