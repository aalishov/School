using P02_LibraryDb.Data.Models;

namespace P02_LibraryDb
{
    public class Program
    {
        public static void Main()
        {
            LibraryDbContext context = new LibraryDbContext();
            PrintBooksAfter2000(context);
        }

        private static void PrintBooksAfter2000(LibraryDbContext context)
        {
            Console.WriteLine($"|{"Title",20} | {"ISBN",15} | {"Year",5}|");
            foreach (var b in context.Books.Where(x => x.YearPublished >= 2000).OrderBy(x=>x.Title))
            {
                Console.WriteLine($"|{new string(b.Title.Take(20).ToArray()),20} | {b.Isbn,15} | {b.YearPublished,5}|");
            }
        }
    }
}
