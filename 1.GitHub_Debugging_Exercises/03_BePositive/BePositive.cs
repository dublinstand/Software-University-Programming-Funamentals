using System;
using System.Collections.Generic;

public class BePositive
{
    public static void Main()
    {
        int countSequences = int.Parse(Console.ReadLine());

        for (int i = 0; i < countSequences; i++)
        {
            string[] input = Console.ReadLine().Trim().Split(' ');      //Trim clears the tabs in the end of the array, Split(' ') - splits the records by space
            List<int> numbers = new List<int>();

            for (int j = 0; j < input.Length; j++)
            {
                if (!input[j].Equals(string.Empty))
                {
                    int num = int.Parse(input[j]);
                    numbers.Add(num);
                }
            }

            bool found = false;

            for (int j = 0; j < numbers.Count; j++)
            {
                int currentNum = numbers[j];

                if (currentNum >= 0)
                {
                    Console.Write(currentNum);
                    found = true;

                    if (found)
                    {
                        Console.Write(" ");
                    }                    
                }
                else if (j + 1 < numbers.Count)
                {
                    currentNum += numbers[j + 1];
                    j++;

                    if (currentNum >= 0)
                    {
                        Console.Write(currentNum);
                        found = true;

                        if (found)
                        {
                            Console.Write(" ");
                        }
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("(empty)");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}