using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

//Use the classes from the previous problem and make a program that read a list of books and print all titles released after given 
//date ordered by date and then by title lexicographically.The date is given if format “day-month-year” at the last line in the input.

class BookLibraryModification
{
    static void Main()
    {
        int numBooks = int.Parse(Console.ReadLine());
        Book[] books = new Book[numBooks];

        for (int i = 0; i < numBooks; i++)
        {
            books[i] = ReadBook();
        }

        Library library = new Library()
        {
            Name = "Library",
            Books = books.ToList()
        };

        string date = Console.ReadLine();
        DateTime parsedDate = DateTime.ParseExact(date, "dd.MM.yyyy", CultureInfo.InvariantCulture);

        SortedDictionary<string, DateTime> sortedBooks = new SortedDictionary<string, DateTime>();

        foreach (var book in library.Books.Where(x => x.ReleaseDate > parsedDate))
        {
            sortedBooks[book.Title] = book.ReleaseDate;

        }

        foreach (var book in sortedBooks.OrderBy(x => x.Value).ThenBy(x => x.Key))
        {
            string date1 = book.Value.ToString("dd.MM.yyyy");
            Console.WriteLine("{0} -> {1}", book.Key, date1);
        }

    }

    private static Book ReadBook()
    {
        string[] token = Console.ReadLine().Split(' ');
        Book book = new Book()
        {
            Title = token[0],
            Author = token[1],
            Publisher = token[2],
            ReleaseDate = DateTime.ParseExact(token[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
            ISBNnumber = token[4],
            Price = decimal.Parse(token[5])
        };

        return book;
    }
}

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Publisher { get; set; }
    public DateTime ReleaseDate { get; set; }
    public string ISBNnumber { get; set; }
    public decimal Price { get; set; }
}

class Library
{
    public string Name { get; set; }
    public List<Book> Books { get; set; }
}

