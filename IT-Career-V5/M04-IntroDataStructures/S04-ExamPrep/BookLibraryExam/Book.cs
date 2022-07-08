public class Book
{
    public Book(string title, double rating)
    {
        this.Title = title;
        this.Rating = rating;
    }
    public string Title { get; private set; }
    public double Rating { get; private set; }
    public override string ToString()
    {
        return $"Book {this.Title} is with {this.Rating} rating.";
    }
}

