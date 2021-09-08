namespace P01_VideoLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class VideoLibrary
    {
        private readonly List<Movie> movies;
        private string name;

        public VideoLibrary(string name)
        {
            this.Name = name;
            this.movies = new List<Movie>();
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public List<Movie> Movies
        {
            get { return this.movies; }
        }

        public void AddMovie(string title, double rating)
        {
            this.movies.Add(new Movie(title, rating));
        }

        public double AverageRating()
        {
            // double sum = 0;
            // foreach (var movie in this.movies)
            // {
            //     sum += movie.Rating;
            // }
            // return sum / this.movies.Count;
            return this.movies.Average(m => m.Rating);
        }

        public List<string> GetMoviesByRating(double rating)
        {
            // List<Movie> movies = new List<Movie>();
            // foreach (var movie in this.movies)
            // {
            //     if (movie.Rating == rating)
            //     {
            //         movies.Add(movie);
            //     }
            // }
            // List<string> moviesWithRating = new List<string>();
            // foreach (var movie in movies)
            // {
            //     moviesWithRating.Add(movie.ToString());
            // }
            // return moviesWithRating;
            return this.movies
                .Where(m => m.Rating == rating)
                .Select(m => m.ToString())
                .ToList();
        }

        public List<Movie> SortByTitle()
        {
            return this.movies.OrderBy(m => m.Title).ToList();
        }

        public List<Movie> SortByRating()
        {
            return this.movies.OrderByDescending(m => m.Rating).ToList();
        }

        public string[] ProvideInformationAboutAllMovies()
        {
            return this.movies.Select(x => x.ToString()).ToArray();
        }

        public bool CheckMovieIsInVideoLibrary(string title)
        {
            return this.movies.FirstOrDefault(m => m.Title == title) != null ? true : false;
        }
    }
}
