using System;
using System.Collections.Generic;

namespace P02_Cinema
{
    public class Program
    {
        //static void Main()
        //{
        //    Cinema arena = new Cinema("Arena");

        //    arena.AddMovie("F9: The Fast Saga",6);
        //    arena.AddMovie("The Many Saints of Newark", 6);
        //    arena.AddMovie("The Little Things", 4);
        //    arena.AddMovie("Black Widow", 7);

        //    //Console.WriteLine(arena.AverageRating());
        //    //Console.WriteLine(string.Join("\n",arena.RemoveMoviesByRating(6)));
        //    Console.WriteLine(new string('*',20));
        //    Console.WriteLine(string.Join("\n", arena.SortByTitle()));
        //    Console.WriteLine(new string('*', 20));
        //    Console.WriteLine(string.Join("\n", arena.SortByRating()));
        //    Console.WriteLine(new string('*', 20));
        //    Console.WriteLine(string.Join("\n", arena.ProvideInformationAboutAllMovies()));
        //}

        static Cinema cinema = new Cinema("CineGrand");

        static void Main(string[] args)
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
                        CheckMovieIsInCinema(cmdArgs[1]);
                        break;
                    case "PrintCinemaInfo":
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

        private static void CheckMovieIsInCinema(string title)
        {
            if (cinema.CheckMovieIsInCinema(title))
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
}
