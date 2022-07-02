using System;
using System.Collections.Generic;

public class Program
{
    static VideoLibrary cinema = new VideoLibrary("VideoLibrary");
    public static void Main(string[] args)
    {
        string line;
        while ("END" != (line = Console.ReadLine()))
        {
            string[] cmdArgs = line.Split(", ");
            switch (cmdArgs[0])
            {
                case "AddMovie":
                    AddMovie(cmdArgs[1], double.Parse(cmdArgs[2]));
                    break;
                case "AverageRating":
                    AverageRating();
                    break;
                case "GetBestMoviesByRating":
                    GetMoviesByRating(double.Parse(cmdArgs[1]));
                    break;
                case "SortByTitle":
                    SortByTitle();
                    break;
                case "SortByRating":
                    SortByRating();
                    break;
                case "CheckMovie":
                    CheckMovieIsInVideoLibrary(cmdArgs[1]);
                    break;
                case "PrintVideoLibraryInfo":
                    ProvideInformationAboutAllMovies();
                    break;
            }
        }
    }
    private static void ProvideInformationAboutAllMovies()
    {
        string[] info = cinema.ProvideInformationAboutAllMovies();
        foreach (string item in info)
        {
            Console.WriteLine(item);
        }
    }
    private static void CheckMovieIsInVideoLibrary(string title)
    {
        if (cinema.CheckMovieIsInVideoLibrary(title))
        {
            Console.WriteLine($"Movie {title} is available.");
        }
        else
        {
            Console.WriteLine($"Movie {title} is not available.");
        }
    }
    private static void SortByRating()
    {
        cinema.SortByRating();
        Console.WriteLine("The worst movie is with rating: " + cinema.Movies[cinema.Movies.Count - 1].Rating);
    }
    private static void SortByTitle()
    {
        cinema.SortByTitle();
        Console.WriteLine("First movie is: " + cinema.Movies[0].Title);
    }
    private static void GetMoviesByRating(double rating)
    {
        List<string> bestMovies = cinema.GetMoviesByRating(rating);
        Console.WriteLine("Most rated movies are: " + string.Join(", ", bestMovies));
    }
    private static void AverageRating()
    {
        double averageRating = cinema.AverageRating();
        Console.WriteLine($"Average rating of movies: {averageRating:f1}");
    }
    private static void AddMovie(string title, double rating)
    {
        cinema.AddMovie(title, rating);
        Console.WriteLine($"Added movie: {title} -> {rating}.");
    }
}

