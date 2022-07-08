using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class BookLibrary
{
    private List<Book> books;

    public BookLibrary(string name)
    {
        this.Name = name;
        this.books = new List<Book>();
    }

    public string Name { get; private set; }

    public List<Book> Books { get { return this.books; }  }

    public void AddBook(string title, double rating)
    {
        this.books.Add(new Book(title, rating));
    }

    public double AverageRating()
    {
        return this.books.Average(x => x.Rating);
    }

    public List<string> GetBooksByRating(double rating)
    {
        return this.books.Where(x => x.Rating > rating).Select(x => x.Title).ToList();
    }

    public List<Book> SortByTitle()
    {
        this.books = this.books.OrderBy(x => x.Title).ToList();
        return this.books;
    }

    public List<Book> SortByRating()
    {
        this.books = this.books.OrderByDescending(x => x.Rating).ToList();
        return this.books;
    }

    public string[] ProvideInformationAboutAllBooks()
    {
        return this.books.Select(x => x.ToString()).ToArray();
    }

    public bool CheckBookIsInBookLibrary(string title)
    {
        return this.books.Any(x => x.Title == title);
    }
}