public class Movie
{
    public Movie(string title, double rating)
    {
        Title = title;
        Rating = rating;
    }

    public string Title { get; private set; }

    public double Rating { get; private set; }

    public override string ToString()
    {
        return $"Movie {Title} is with {Rating:f1} rating.";
    }
}

