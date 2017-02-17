using System;
using System.Collections.Generic;
using System.Linq;

class ArrayManipulator
{
    static void Main()
    {
        List<int> intArray = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        while (true)
        {
            string[] commands = Console.ReadLine().Split(' ').ToArray();

            string command = commands[0];


            if (command.Equals("add"))
            {
                addElement(intArray, commands);
            }
            else if (command.Equals("contains"))
            {
                printIndexOfMatchingInt(intArray, commands);
            }
            else if (command.Equals("addMany"))
            {
                addMany(intArray, commands);
            }
            else if (command.Equals("remove"))
            {
                remove(intArray, commands);
            }
            else if (command.Equals("shift"))
            {
                shift(intArray, commands);
            }
            else if (command.Equals("sumPairs"))
            {
                intArray = sumParis(intArray);
            }
            else if (command.Equals("print"))
            {
                Console.WriteLine("[" + string.Join(", ", intArray) + "]");
                break;
            }

        }


    }

    private static List<int> sumParis(List<int> intArray)
    {
        List<int> newIntList = new List<int>();

        while (intArray.Count() >= 2)
        {
            int sum = intArray[0] + intArray[1];
            newIntList.Add(sum);
            intArray.RemoveAt(0);
            intArray.RemoveAt(0);
        }

        if (intArray.Count() == 1)
        {
            newIntList.Add(intArray[0]);
        }

        return newIntList;
    }

    private static void shift(List<int> intArray, string[] commands)
    {
        int numberOfPositions = int.Parse(commands[1]);

        while (numberOfPositions > 0)
        {
            int first = intArray[0];
            intArray.RemoveAt(0);
            intArray.Insert(intArray.Count, first);
            numberOfPositions--;
        }
    }

    private static void remove(List<int> intArray, string[] commands)
    {
        int index = int.Parse(commands[1]);

        intArray.RemoveAt(index);
    }

    private static void addMany(List<int> intArray, string[] commands)
    {
        int index = int.Parse(commands[1]);

        for (int i = commands.Count() - 1; i > 1; i--)
        {
            int element = int.Parse(commands[i]);
            intArray.Insert(index, element);
        }


    }

    static void addElement(List<int> list, string[] commands)
    {
        int index = int.Parse(commands[1]);
        int value = int.Parse(commands[2]);

        list.Insert(index, value);
    }
    static void printIndexOfMatchingInt(List<int> list, string[] commands)
    {
        int value = int.Parse(commands[1]);

        if (list.Contains(value))
        {
            //Console.WriteLine(list.IndexOf(value));

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == value)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine("-1");
        }
    }
}

