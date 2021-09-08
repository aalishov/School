using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P02_Library
{
    public class Shelf
    {
        private readonly List<Book> books;

        public Shelf()
        {
            this.books = new List<Book>();
        }

        public Book Head { get => books.FirstOrDefault(); }

        public Book Tail { get => books.LastOrDefault(); }

        public int Count { get => books.Count; }

        public void AddBook(string bookId)
        {
            this.books.Add(new Book(bookId));
        }

        public void AddSpecialBook(string bookId)
        {
            this.books.Insert(0, new Book(bookId));
        }

        public Book CheckBookIsPresent(string bookId)
        {
            return this.books.FirstOrDefault(b => b.Id == bookId);
        }

        public bool ReleaseBook(string bookId)
        {
            Book book = this.books.FirstOrDefault(b => b.Id == bookId);
            return this.books.Remove(book);
        }

        public bool ReleaseBook(int index)
        {
            if (index >= 0 && index < this.books.Count)
            {
                this.books.RemoveAt(index);
                return true;
            }
            return false;
        }

        public StringBuilder ShelfInformation()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var book in this.books)
            {
                sb.AppendLine(book.ToString());
            }
            return sb;
        }
    }
}
