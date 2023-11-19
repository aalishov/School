using System.Text;

namespace P00_DemoClass_v1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Book b1 = new Book("C# advanced", "Nakov", 350);
            Console.WriteLine(b1);
        }
    }
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public int Pages { get; set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public Book(string title, string author, int pages) : this(title, author)
        {
            Pages = pages;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Title: {Title}");
            sb.AppendLine($"Author: {Author}");
            sb.AppendLine($"Pages: {Pages}");
            return sb.ToString().TrimEnd();
        }
    }
}