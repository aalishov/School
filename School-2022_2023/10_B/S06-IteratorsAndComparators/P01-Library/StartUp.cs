
namespace IteratorsAndComparators
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            Book b1 = new Book("Book 1", 2021, "Author 1");
            Book b2 = new Book("Book 2", 2015);
            Book b3 = new Book("Book 3", 2022, "Author 1", "Author 3");
            Library library = new Library(b1, b2, b3);

            foreach (var book in library)
            {
                Console.WriteLine(book.Title);
            }
        }
    }
}
