public class Movie
{
    public Movie(string title, double rating)
    {
        this.Title = title;
        this.Rating = rating;
    }
    public string Title { get; private set; }
    public double Rating { get; private set; }
    public override string ToString()
    {
        return $"Movie {this.Title} is with {this.Rating:f1} rating.";
    }
}

