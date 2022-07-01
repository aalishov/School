using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ShelfList
{
    private readonly List<Book> books = new List<Book>();
    public int Count { get { return this.books.Count; } }
    public Book Head { get { return this.books[0]; } }
    public Book Tail { get { return this.books[this.Count - 1]; } }
    public void AddBook(string bookId)
    {
        Book book = new Book(bookId);
        if (this.Count > 0)
        {
            this.Tail.Next = book;
        }
        this.books.Add(book);
    }
    public void AddSpecialBook(string bookId)
    {
        Book book = new Book(bookId);
        if (this.Count > 0)
        {
            book.Next = this.Head;
        }
        this.books.Insert(0, book);
    }
    public Book CheckBookIsPresent(string bookId)
    {
        return this.books.FirstOrDefault(x => x.Id == bookId);
    }
    public bool ReleaseBook(int index)
    {
        if (index < 0 || index >= this.Count)
        {
            return false;
        }
        Book releaseBook = this.books[index];
        if (index - 1 >= 0)
        {
            this.books[index - 1].Next = releaseBook.Next;
        }
        this.books.RemoveAt(index);
        return true;
    }
    public bool ReleaseBook(string bookId)
    {
        int index= this.books.FindIndex(x=>x.Id==bookId);
        return ReleaseBook(index);
    }
    public StringBuilder ShelfInformation()
    {
        if (this.books.Any())
        {
            StringBuilder sb = new StringBuilder();

            foreach (var b  in books)
            {
                sb.AppendLine(b.ToString());
            }
            return sb;
        }
        else
        {
            return new StringBuilder("Shelf is empty!");
        }
    }

}

