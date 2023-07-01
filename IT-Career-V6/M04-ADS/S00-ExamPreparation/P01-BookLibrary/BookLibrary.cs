using System.Collections.Generic;
using System.Linq;


public class BookLibrary
{
    private readonly List<Book> books;
    private string name;

    public BookLibrary(string name)
    {
        Name = name;
        books = new List<Book>();
    }

    public string Name
    {
        get { return name; }
        private set
        {
            name = value;
        }
    }

    public IReadOnlyList<Book> Books { get { return books; } }

    public void AddBook(string title, double rating)
    {
        books.Add(new Book(title, rating));
    }
    public double AverageRating()
    {
        return books.Average(x => x.Rating);
    }
    public List<string> GetBooksByRating(double rating)
    {
        List<string> result = new List<string>();
        //books.Where(x => x.Rating > rating).ToList().ForEach(x=>result.Add(x.Title));

        List<Book> booksWithRating = books.Where(x => x.Rating > rating).ToList();

        foreach (var book in booksWithRating)
        {
            result.Add(book.Title);
        }

        return result;
    }

    public List<Book> SortByTitle()
    {
        List<Book> sortedBooks = books.OrderBy(x => x.Title).ToList();

        books.Clear();
        foreach (var book in sortedBooks)
        {
            books.Add(book);
        }

        return sortedBooks;
    }

    public List<Book> SortByRating()
    {
        List<Book> sortedBooks = books.OrderByDescending(x => x.Rating).ToList();

        books.Clear();
        foreach (var book in sortedBooks)
        {
            books.Add(book);
        }

        return sortedBooks;
    }
    public string[] ProvideInformationAboutAllBooks()
    {
        //string[] bookInfo= new string[books.Count];
        //for (int i = 0; i < books.Count; i++)
        //{
        //    bookInfo[i] = books[i].ToString();
        //}

        //return bookInfo;

        List<string> bookInfo = new List<string>();
        books.ForEach(book => bookInfo.Add(book.ToString()));
        return bookInfo.ToArray();
    }
    public bool CheckBookIsInBookLibrary(string title)
    {
       return books.Any(book => book.Title == title);
    }

}

