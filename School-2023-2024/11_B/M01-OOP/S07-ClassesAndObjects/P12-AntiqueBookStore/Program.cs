using System.Text;


internal class Program
{
    static void Main(string[] args)
    {
        List<Book> books = new List<Book>();
        string[] arr = Console.ReadLine().Split(", ");
        string cmd = arr[0];
        while (true)
        {
            if (cmd == "End")
            {
                break;
            }
            string title = cmd;
            string author = arr[1];
            int pubDate = int.Parse(arr[2]);
            double price = double.Parse(arr[3]);
            string publisher = arr[4];
            string discount = arr[5];
            Book book = new Book(title, author, pubDate, price, publisher, discount);
            books.Add(book);
        }
        books = books.OrderBy(b => b.Author).ToList();
        books.ToString();
    }
}

public class Book
{
    public Book(string title, string author, int pubDate, double price)
    {
        Title = title;
        Author = author;
        PubDate = pubDate;
        Price = price;
        Publisher = "Unknown";
        Discount = "Unavailabl";
    }
    public Book(string title, string author, int pubDate, double price, string publisher) : this(title, author, pubDate, price)
    {
        Publisher = publisher;
    }

    public Book(string title, string author, int pubDate, double price, string publisher, string discount) : this(title, author, pubDate, price)
    {
        Publisher = publisher;
        Discount = discount;
    }
    public string Title { get; set; }
    public string Author { get; set; }
    public int PubDate { get; set; }
    public double Price { get; set; }
    public string Publisher { get; set; }
    public string Discount { get; set; }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Title : {Title}");
        sb.AppendLine($"Author: {Author}");
        sb.AppendLine($"Publication Date: {PubDate}");
        sb.AppendLine($"Price: {Price}");
        sb.AppendLine($"Publisher: {Publisher}");
        sb.AppendLine($"Discount: {Discount}");
        return sb.ToString().TrimEnd();
    }
}
