using System;
using System.Collections.Generic;
using System.Linq;

//Write a program that generate random fake advertisement message to extol some product.The messages must consist of 4 parts: laudatory phrase + event + author + city. Use the following predefined parts:
//•	Phrases – {“Excellent product.”, “Such a great product.”, “I always use that product.”, “Best product of its category.”, “Exceptional product.”, “I can’t live without this product.”}
//•	Events – {“Now I feel good.”, “I have succeeded with this product.”, “Makes miracles. I am happy of the results!”, “I cannot believe but now I feel awesome.”, ”Try it yourself, I am very satisfied.”, “I feel great!”}
//•	Author – {“Diana”, “Petya”, “Stella”, “Elena”, “Katya”, “Iva”, “Annie”, “Eva”}
//•	Cities – {“Burgas”, “Sofia”, “Plovdiv”, “Varna”, “Ruse”}
//The format of the output message is: { phrase} {event} { author} – { city}.
//As an input you take the number of messages to be generated. Print each random message at a separate line.


class AdvertisementMessage
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        String[] phrases = {"Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.",
            "Exceptional product.", "I can’t live without this product."};

        String[] events = {"Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!",
            "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"};

        String[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

        String[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

        Random utils = new Random();


        for (int i = 0; i < num; i++)
        {
            string phrase = phrases[utils.Next(0, phrases.Length)];
            string eventa = events[utils.Next(0, events.Length)];
            string author = authors[utils.Next(0, authors.Length)];
            string city = cities[utils.Next(0, cities.Length)];

            Console.WriteLine($"{phrase} {eventa} {author} - {city}");
        }

    }
}

