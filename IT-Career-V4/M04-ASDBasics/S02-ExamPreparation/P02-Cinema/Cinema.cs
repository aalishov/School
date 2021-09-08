using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P02_Cinema
{
    public class Cinema
    {
        private  List<Movie> movies;
        public Cinema(string name)
        {
            this.Name = name;
            this.movies = new List<Movie>();
        }
        public string Name { get; set; }
        public List<Movie> Movies { get => this.movies; }
        public void AddMovie(string title, double rating)
        {
            this.movies.Add(new Movie(title, rating));
        }
        public double AverageRating()
        {
            return this.movies.Average(x => x.Rating);
        }
        public List<string> RemoveMoviesByRating(double rating)
        {
            List<Movie> moviesWithRating = this.movies.Where(x => x.Rating == rating).ToList();
            this.movies.RemoveAll(x => x.Rating == rating);
            List<string> result = new List<string>();
            foreach (var movie in moviesWithRating)
            {
                result.Add(movie.ToString());
            }
            return result;
        }
        public List<Movie> SortByTitle()
        {
            this.movies = this.movies.OrderBy(x => x.Title).ToList();
            return this.movies;
        }
        public List<Movie> SortByRating()
        {
            this.movies = this.movies.OrderByDescending(x => x.Rating).ToList();
            return this.movies;
        }

        public string[] ProvideInformationAboutAllMovies()
        {
            List<string> result = new List<string>();
            foreach (var m in this.movies)
            {
                result.Add(m.ToString());
            }
            return result.ToArray();
        }

        public bool CheckMovieIsInCinema(string title)
        {
            Movie search = this.movies.FirstOrDefault(x => x.Title == title);
            //if (search!=null)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            return search != null ? true : false;
        }

        public List<string> GetMoviesByRating(double rating)
        {
            List<string> result = new List<string>();
            foreach (var m in this.movies.Where(x => x.Rating >= rating))
            {
                result.Add(m.Title);
            }
            return result;
        }
    }
}
