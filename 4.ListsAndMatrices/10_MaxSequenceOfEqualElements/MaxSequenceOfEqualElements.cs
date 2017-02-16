using System;
using System.Collections.Generic;
using System.Linq;

class MaxSequenceOfEqualElements
{
    static void Main()
    {
        List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        int num = 0;
        int bestLength = 1;
        int currentLength = 1;
        int pos = 0;
        

        while (pos != nums.Count - 1)
        {
            if (nums[pos] == nums[pos + 1])
            {
                currentLength++;

                if (bestLength < currentLength)
                {
                    num = nums[pos];
                    bestLength = currentLength;
                    
                }
            }
            else
            {                
                currentLength = 1;            
            }          

            pos++;

            if (bestLength == 1)
            {
                num = nums[0];
            }
        }

        for (int i = 0; i < bestLength; i++)
        {
            Console.Write($"{num} ");
        }

    }
}

