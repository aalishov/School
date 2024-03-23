namespace BookManagement.Services
{
    using BookManagement.Common;
    using BookManagement.Data;
    using BookManagement.Data.Models;
    using BookManagement.Services.Enums;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class BooksService
    {
        AppDbContext context;
        public BooksService()
        {
            this.context = new AppDbContext();
        }
        public BooksService(AppDbContext context)
        {
            this.context = context;
        }

        public int Add(Book book)
        {
            ValidateBook(book);

            context.Books.Add(book);
            context.SaveChanges();
            return book.Id;
        }
        public Book? GetBookById(int id)
        {
            return context.Books.Find(id);
        }

        public List<Book> GetBooks(int page = 1, int itemsPerPage = 10, bool ascSort = true, BookSortBy sortBy = BookSortBy.Title)
        {
            IQueryable<Book> result = null;

            //Sort books
            if (ascSort)
            {
                switch (sortBy)
                {
                    case BookSortBy.Title:
                        result = context.Books.OrderBy(x => x.Title);
                        break;
                    case BookSortBy.Author:
                        result = context.Books.OrderBy(x => x.Author);
                        break;
                    case BookSortBy.Year:
                        result = context.Books.OrderBy(x => x.Year);
                        break;
                    case BookSortBy.Price:
                        result = context.Books.OrderBy(x => x.Price);
                        break;
                }
            }
            else
            {
                switch (sortBy)
                {
                    case BookSortBy.Title:
                        result = context.Books.OrderByDescending(x => x.Title);
                        break;
                    case BookSortBy.Author:
                        result = context.Books.OrderByDescending(x => x.Author);
                        break;
                    case BookSortBy.Year:
                        result = context.Books.OrderByDescending(x => x.Year);
                        break;
                    case BookSortBy.Price:
                        result = context.Books.OrderByDescending(x => x.Price);
                        break;
                }
            }

            return result
              .Skip((page - 1) * itemsPerPage)
              .Take(itemsPerPage)
              .ToList();
        }

        public int GetBooksCount()
        {
            return context.Books.Count();
        }

        public int EditBook(Book book)
        {
            Book? editBook = this.GetBookById(book.Id);
            if (editBook == null)
            {
                throw new ArgumentException(ExceptionMessages.BookNotFound);
            }

            ValidateBook(book);

            context.Books.Update(book);
            context.SaveChanges();
            return book.Id;
        }
        public int EditBookGanres(Book book)
        {
            context.Books.Update(book);
            context.SaveChanges();
            return book.Id;
        }


        public int DeleteBook(int id)
        {
            Book? book = this.GetBookById(id);
            if (book == null)
            {
                throw new ArgumentException(ExceptionMessages.BookNotFound);
            }
            context.Books.Remove(book);
            context.SaveChanges();
            return book.Id;
        }

        public string[] GetAuthorsList()
        {
            return context.Books
                .Select(x => x.Author)
                .Distinct()
                .ToArray();
        }

        public string[] Search(BookSearchBy searchBy, string text)
        {
            IQueryable<Book> result = null;
            switch (searchBy)
            {
                case BookSearchBy.Title:
                    result = context.Books.Where(x => x.Title.Contains(text)).Take(10);
                    break;
                case BookSearchBy.Author:
                    result = context.Books.Where(x => x.Author.Contains(text)).Take(10);
                    break;
                default:
                    break;
            }
          return  result.Select(b => $"{b.Title} - {b.Author} - {b.Year}").ToArray();
        }

        private static void ValidateBook(Book book)
        {
            if (string.IsNullOrWhiteSpace(book.Title))
            {
                throw new ArgumentException(ExceptionMessages.InvalidBookTitle);
            }
            if (string.IsNullOrWhiteSpace(book.Author))
            {
                throw new ArgumentException(ExceptionMessages.InvalidBookAuthor);
            }
            if (book.Year < 1980 || book.Year > DateTime.Now.Year)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.InvalidBookYear, 1980, DateTime.Now.Year));
            }
            if (book.Price <= 0)
            {
                throw new ArgumentException(ExceptionMessages.InvalidBookPrice);
            }
        }

    }
}
