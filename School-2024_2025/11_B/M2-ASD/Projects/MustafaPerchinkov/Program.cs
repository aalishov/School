using KURSOV_PROEKT;

public class Program
{
    public static void Main()
    {
        CatalogManager catalog = new CatalogManager();
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("=== MOVIE CATALOG ===");
            Console.WriteLine("1. Add movie");
            Console.WriteLine("2. Show all movies");
            Console.WriteLine("3. Search movie");
            Console.WriteLine("4. Delete movie");
            Console.WriteLine("5. Edit movie");
            Console.WriteLine("6. Exit");
            Console.Write("Choose option: ");


            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    catalog.AddMovie();
                    break;
                case "2":
                    catalog.DisplayMovies();
                    break;
                case "3":
                    catalog.SearchMovie();
                    break;
                case "4":
                    catalog.DeleteMovie();
                    break;
                case "5":
                    catalog.EditMovie();
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Invalid option. Press any key...");
                    Console.ReadKey();
                    break;
            }
        }
    }
}