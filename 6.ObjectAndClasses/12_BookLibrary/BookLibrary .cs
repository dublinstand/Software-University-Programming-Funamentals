using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

//To model a book library, define classes to hold a book and a library.The library must have a name and a list of books.
//The books must contain the title, author, publisher, release date, ISBN-number and price.
//Read a list of books, add them to the library and print the total sum of prices by author, ordered descending by 
//    price and then by author’s name lexicographically.
//Books in the input will be in format {title} {author} {publisher} {release date} {ISBN} {price}.


class BookLibrary
{
    static void Main()
    {
        int numBooks = int.Parse(Console.ReadLine());
        Book[] books = new Book[numBooks];

        for (int i = 0; i < numBooks; i++)
        {
            books[i] = ReadBook();
        }

        Library library = new Library() {
            Name = "Library",
            Books = books.ToList()
        };


        Dictionary<string, decimal> authors = new Dictionary<string, decimal>();

        foreach (Book book in library.Books)
        {
            if (authors.ContainsKey(book.Author))
            {
                authors[book.Author] += book.Price;
            }
            else
            {
                authors[book.Author] = book.Price;
            }
        }

        foreach (var pair in authors.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
        {
            Console.WriteLine("{0} -> {1:F2}", pair.Key, pair.Value);
        }



    }

    private static Book ReadBook()
    {
        string[] token = Console.ReadLine().Split(' ');
        Book book = new Book() { Title = token[0],
            Author = token[1],
            Publisher = token[2],
            ReleaseDate = DateTime.ParseExact(token[3], "d.M.yyyy", CultureInfo.InvariantCulture),
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

