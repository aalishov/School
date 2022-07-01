using System;

public class Program
{
    static void Main()
    {
        Book b1 = new Book("Book1");
        Book b2 = new Book("Book2");
        Book b3 = new Book("Book3");
        Book b4 = new Book("Book4");

        Shelf shelfList = new Shelf();

        shelfList.AddBook("Book1");
        shelfList.AddBook("Book2");
        shelfList.AddBook("Book3");
        shelfList.AddBook("Book4");

        shelfList.AddSpecialBook("BookSpecial");
        

        //Console.WriteLine($"Search: {shelfList.CheckBookIsPresent("BookSpecial")}");
        Console.WriteLine($"Remove at 2: {shelfList.ReleaseBook(4)}");
        Console.WriteLine($"Head: {shelfList.Head}");
        Console.WriteLine($"Head.Next: {shelfList.Head.Next}");
        Console.WriteLine($"Head.Next.Next: {shelfList.Head.Next.Next}");
        Console.WriteLine($"Head.Next.Next.Next: {shelfList.Head.Next.Next.Next}");
        Console.WriteLine($"Tail: {shelfList.Tail}");
        Console.WriteLine($"Count: {shelfList.Count}");
    }
}

