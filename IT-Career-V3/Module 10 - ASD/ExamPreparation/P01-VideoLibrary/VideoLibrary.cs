namespace P01_VideoLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class VideoLibrary
    {
        private string name;
        private readonly List<Movie> movies;


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
            this.movies.Add(new Movie(title,rating));               
        }
        public double AverageRating()
        {
            return this.movies.Average(m => m.Rating); 
        }

        public List<string> GetMoviesByRating(double rating)
        {
            ////LINQ Where
            //List<Movie> moviesWithRating = new List<Movie>();
            //foreach (var movie in this.movies)
            //{
            //    if (movie.Rating==rating)
            //    {
            //        moviesWithRating.Add(movie);
            //    }
            //}
            ////LINQ Select
            //List<string> titles = new List<string>();
            //foreach (var movie in moviesWithRating)
            //{
            //    titles.Add(movie.Title);
            //}

            //return titles;

            return this.movies
                .Where(x => x.Rating == rating)
                .Select(m => m.Title)
                .ToList();
        }

        public List<Movie> SortByTitle()
        {
            return this.movies.OrderBy(x => x.Title).ToList();                           
        }

        public List<Movie> SortByRating()
        {
            return this.movies.OrderByDescending(x => x.Rating).ToList();
        }

        public string[] ProvideInformationAboutAllMovies()
        {
            return this.movies.Select(x => x.ToString()).ToArray();                        
        }

        public bool CheckMovieIsInVideoLibrary(string title)
        {
            return this.movies.FirstOrDefault(x => x.Title == title) != null ? true : false;            
        }

    }
}
