using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KURSOV_PROEKT.Director;

namespace KURSOV_PROEKT
{
    public class Movie
    {
        private string title;
        private string genre;
        private int year;
        private Director director;
        private List<Actor> actors;

        public string Title
        {
            get => title;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Title cannot be empty.");
                title = value;
            }
        }
        public string Genre { get => genre; set => genre = value; }
        public int Year
        {
            get => year;
            set
            {
                if (value < 1888 || value > DateTime.Now.Year)
                    throw new ArgumentException("Invalid year for a movie.");
                year = value;
            }
        }
        public Director Director { get => director; set => director = value; }
        public List<Actor> Actors { get => actors; set => actors = value; }

        public Movie(string title, string genre, int year, Director director)
        {
            this.Title = title;
            this.genre = genre;
            this.Year = year;
            this.Director = director;
            this.Actors = new List<Actor>();
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Genre: {genre}");
            Console.WriteLine($"Year: {year}");
            director.DisplayInfo();
        }
    }
}
