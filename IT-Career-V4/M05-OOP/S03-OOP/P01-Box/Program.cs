namespace P01_Box
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            Box<Book> books = new Box<Book>();

            books.Add(new Book("Хари Потър", "Д.Р.", 350, 25));
            books.Add(new Book("Хари Потър 2", "Д.Р.", 280, 15));

            Console.WriteLine(books.Remove());

            List<int> nums = new List<int>();

        }
    }
}
