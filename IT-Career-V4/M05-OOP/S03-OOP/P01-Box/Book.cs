namespace P01_Box
{
    public class Book
    {
        public Book(string title, string author)
        {
            this.Title = title;
            this.Author = author;
        }

        public Book(string title, string author, int pages, double price)
            :this(title,author)
        {
            this.Pages = pages;
            this.Price = price;
        }

        public string Title { get; set; }

        public string Author { get; set; }

        public int Pages { get; set; }

        public double Price { get; set; }

        public override string ToString()
        {
            return $"Title: {this.Title}, author: {this.Author}, price:{this.Price}";
        }
    }
}
