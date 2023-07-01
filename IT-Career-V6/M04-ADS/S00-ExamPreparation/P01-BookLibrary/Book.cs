public class Book
{
    private string title;
    private double rating;

    public Book(string title, double rating)
    {
        Title = title;
        Rating = rating;
    }

    public string Title
    {
        get { return title; }
        private set
        {
            title = value;
        }
    }
    public double Rating
    {
        get { return rating; }
        private set
        {
            rating = value;
        }
    }

    public override string ToString()
    {
        return $"Book {Title} is with {Rating:f1} rating.";
    }
}

