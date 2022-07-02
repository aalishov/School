using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class VideoLibrary
{
    private List<Movie> movies;

    public VideoLibrary(string name)
    {
        this.Name = name;
        this.movies = new List<Movie>();
    }
    public string Name { get; private set; }
    public List<Movie> Movies { get { return this.movies; } }
    public void AddMovie(string title, double rating)
    {
        this.movies.Add(new Movie(title, rating));
    }
    public double AverageRating()
    {
        return this.movies.Average(x => x.Rating);
    }
    public List<string> GetMoviesByRating(double rating)
    {
        return this.movies
            .Where(x => x.Rating > rating)
            .Select(x => x.Title)
            .OrderBy(x=>x)
            .ToList();
    }
    public List<Movie> SortByTitle()
    {
        this.movies = this.movies.OrderBy(x => x.Title).ToList();
        return this.movies;
    }
    public List<Movie> SortByRating()
    {
        this.movies = this.movies.OrderBy(x => x.Rating).ToList();
        return this.movies;
    }
    public string[] ProvideInformationAboutAllMovies()
    {
        return this.movies.Select(x => x.ToString()).ToArray();
    }
    public bool CheckMovieIsInVideoLibrary(string title)
    {
        return this.movies.Any(x => x.Title == title);
    }
}

