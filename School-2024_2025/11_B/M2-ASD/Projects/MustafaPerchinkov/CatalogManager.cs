using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURSOV_PROEKT
{
    public class CatalogManager
    {
        private List<Movie> movies = new List<Movie>();

        public void AddMovie()
        {
            Console.Clear();
            Console.Write("Title: ");
            string title = Console.ReadLine();

            Console.Write("Genre: ");
            string genre = Console.ReadLine();

            Console.Write("Year: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Director: ");
            string directorName = Console.ReadLine();
            Director director = new Director(directorName, 0);

            Movie movie = new Movie(title, genre, year, director);
            movies.Add(movie);

            Console.WriteLine("Movie added. Press any key...");
            Console.ReadKey();
        }

        public void DisplayMovies()
        {
            Console.Clear();
            foreach (var movie in movies)
            {
                movie.DisplayInfo();
                Console.WriteLine("------------------------");
            }
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }

        public void SearchMovie()
        {
            Console.Clear();
            Console.Write("Enter movie title to search: ");
            string search = Console.ReadLine();

            bool found = false;

            foreach (var movie in movies)
            {
                if (movie.Title.ToLower().Contains(search.ToLower()))
                {
                    movie.DisplayInfo();
                    Console.WriteLine("------------------------");
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("The movie doesn't exist.");
            }

            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }

        public void DeleteMovie()
        {
            Console.Clear();
            Console.Write("Enter title to delete: ");
            string title = Console.ReadLine();

            int removedCount = movies.RemoveAll(m => m.Title.ToLower() == title.ToLower());

            if (removedCount == 0)
            {
                Console.WriteLine("The movie doesn't exist.");
            }
            else
            {
                Console.WriteLine("The movie was deleted.");
            }

            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
        public void EditMovie()
        {
            Console.Clear();
            Console.Write("Enter the title of the movie to edit: ");
            string searchTitle = Console.ReadLine();

            Movie movie = movies.FirstOrDefault(m => m.Title.ToLower() == searchTitle.ToLower());

            if (movie == null)
            {
                Console.WriteLine("The movie doesn't exist. Press any key...");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Leave blank to keep the current value.");

            Console.Write($"New title (current: {movie.Title}): ");
            string newTitle = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(newTitle))
            {
                movie.Title = newTitle;
            }

            Console.Write($"New genre (current: {movie.Genre}): ");
            string newGenre = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(newGenre))
            {
                movie.Genre = newGenre;
            }

            Console.Write($"New year (current: {movie.Year}): ");
            string yearInput = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(yearInput))
            {
                try
                {
                    movie.Year = int.Parse(yearInput);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Invalid year: {ex.Message}");
                }
            }

            Console.Write($"New director name (current: {movie.Director.Name}): ");
            string newDirector = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(newDirector))
            {
                movie.Director.Name = newDirector;
            }

            Console.WriteLine("Movie updated. Press any key...");
            Console.ReadKey();
        }
    }
}
