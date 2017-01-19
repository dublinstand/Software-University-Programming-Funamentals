using System;
using System.Linq;

class RandomizeWords
{
    static void Main()
    {
        string[] words = Console.ReadLine().Split(' ').ToArray();

        Random rnd = new Random();

        for (int pos1 = 0; pos1 < words.Length; pos1++)
        {

            var pos2 = rnd.Next(words.Length);
            var old = words[pos1];
            words[pos1] = words[pos2];
            words[pos2] = old;
        }

        Console.WriteLine(string.Join("\r\n", words));

        //for (int i = 0; i < words.Length; i++)
        //{
        //    Console.WriteLine(words[i]);
        //}
    }
}
