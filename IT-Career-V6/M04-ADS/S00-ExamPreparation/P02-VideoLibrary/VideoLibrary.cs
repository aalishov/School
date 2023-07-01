using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class VideoLibrary
{
    private List<Movie> movies;

    public VideoLibrary(string name)
    {
        Name = name;
        movies = new List<Movie>();
    }

    public string Name { get; private set; }

    public IReadOnlyList<Movie> Movies
    {
        get { return movies; }
    }

    public void AddMovie(string title, double rating)
    {
        movies.Add(new Movie(title, rating));
    }

    public double AverageRating()
    {
        return movies.Average(x => x.Rating);
    }

    public List<string> GetMoviesByRating(double rating)
    {
        //List<string> moviesWithRating = new List<string>();

        //movies.Where(x => x.Rating > rating)
        //    .ToList()
        //    .ForEach(x => moviesWithRating.Add(x.Title));

        //return moviesWithRating;

        return movies
            .Where(x => x.Rating > rating)
            .Select(x => x.Title)
            .ToList();
    }

    public List<Movie> SortByTitle()
    {
        movies = movies.OrderBy(x => x.Title).ToList();
        return movies;
    }

    public List<Movie> SortByRating()
    {
        movies = movies.OrderByDescending(x => x.Rating).ToList();
        return movies;
    }

    public string[] ProvideInformationAboutAllMovies()
    {
        return movies.Select(x => x.ToString()).ToArray();
    }

    public bool CheckMovieIsInVideoLibrary(string title)
    {
        //return movies.Any(x=>x.Title==title);

        return movies.Any(x => x.Title.CompareTo(title) == 0);
    }

}

