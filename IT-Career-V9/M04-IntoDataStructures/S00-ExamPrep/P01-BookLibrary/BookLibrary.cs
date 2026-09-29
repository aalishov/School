using System.Collections.ObjectModel;

public class BookLibrary
{
    private readonly List<Book> books;

    public BookLibrary(string name)
    {
        Name = name;
        books = new List<Book>();
    }

    public string Name { get; private set; }

    public ReadOnlyCollection<Book> Books => books.AsReadOnly();

    public void AddBook(string title, double rating)
    {
        books.Add(new Book(title, rating));
    }

    public double AverageRating()
    {
        if (books.Count == 0) { return 0; }
        return books.Average(b => b.Rating);
    }
    
    public bool CheckBookIsInBookLibrary(string title)
    {
        return books.Any(x => x.Title == title);
    }

    public List<string> GetBooksByRating(double rating)
    {
        return books
            .Where(b => b.Rating > rating)
            .Select(b => b.Title)
            .ToList();
    }

    public string[] ProvideInformationAboutAllBooks()
    {
        string[] result = new string[books.Count];

        for (int i = 0; i < books.Count; i++)
        {
            result[i] = books[i].ToString();
        }

        return result;
    }

    public List<Book> SortByTitle()
    {
        List<Book> sortedBooks = books.OrderBy(x => x.Title).ToList();
        books.Clear();
        books.AddRange(sortedBooks);
        return sortedBooks;
    }

    public List<Book> SortByRating()
    {
        List<Book> sortedBooks = books.OrderByDescending(x => x.Rating).ToList();
        books.Clear();
        books.AddRange(sortedBooks);
        return sortedBooks;
    }
}

