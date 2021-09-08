namespace P02_Cinema
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Movie
    {
        public Movie(string title, double rating)
        {
            this.Title = title;
            this.Rating = rating;
        }

        public string Title { get; set; }
        public double Rating { get; set; }

        public override string ToString()
        {
            return $"Movie {this.Title} is with {this.Rating:f1} rating.";
        }
    }
}
