using System;
using System.Text;

namespace P02_Library
{
    public class Program
    {
        public static Shelf shelf = new Shelf();
        static void Main(string[] args)
        {
            string line;
            while ("END" != (line = Console.ReadLine()))
            {
                string[] cmdArgs = line.Split(' ');
                switch (cmdArgs[0])
                {
                    case "Add":
                        AddBook(cmdArgs[1]);
                        break;
                    case "AddSpecial":
                        AddSpecialBook(cmdArgs[1]);
                        break;
                    case "Check":
                        CheckBookIsPresent(cmdArgs[1]);
                        break;
                    case "Release":
                        ReleaseBook(cmdArgs[1]);
                        break;
                    case "Count":
                        CountBooks();
                        break;
                    case "Info":
                        ShelfInformation();
                        break;
                }
            }
        }
        private static void CountBooks()
        {
            Console.WriteLine("Books count: " + shelf.Count);
        }
        private static void ShelfInformation()
        {
            StringBuilder info = shelf.ShelfInformation();
            Console.WriteLine(info.ToString().Trim());
        }
        private static void ReleaseBook(string arg)
        {
            bool released;
            try
            {
                released = shelf.ReleaseBook(int.Parse(arg));
            }
            catch (Exception e)
            {
                released = shelf.ReleaseBook(arg);
            }
            if (released)
            {
                Console.WriteLine("Released book");
            }
            else
            {
                Console.WriteLine("Book not found");
            }
        }
        private static void CheckBookIsPresent(string bookId)
        {
            var book = shelf.CheckBookIsPresent(bookId);
            Console.WriteLine(book != null ? $"{book} is present."
                : "Book is not present");
        }
        private static void AddSpecialBook(string bookId)
        {
            shelf.AddSpecialBook(bookId);
        }
        private static void AddBook(string bookId)
        {
            shelf.AddBook(bookId);
        }
    }

}
