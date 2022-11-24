using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        List<Book> books = new List<Book>();
       
        while (true)
        {
            string[] input = Console.ReadLine().Split(", ").ToArray();
            if (input[0] == "End")
            {
                break;
            }
            Book book = null;
            if (input.Length==6)
            {
                 book = new Book(input[0], input[1], int.Parse(input[2]), decimal.Parse(input[3]), input[4], input[5]);
            }
            else
            {
                book = new Book(input[0], input[1], int.Parse(input[2]), decimal.Parse(input[3]));
            }
            books.Add(book);
        }
        foreach (var book in books.OrderBy(x=>x.Author))
        {
            Console.WriteLine($"Title : {book.Title}");
            Console.WriteLine($"\tAuthor: {book.Author}");
            Console.WriteLine($"\tPublication Date: {book.PubDate}");
            Console.WriteLine($"\tPrice: {book.Price}");
            Console.WriteLine($"\tPublisher: {book.Publisher}");
            Console.WriteLine($"\tDiscount: {book.Discount}");
        }

       
       


    }
}

