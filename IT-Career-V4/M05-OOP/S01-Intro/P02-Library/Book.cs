using System;
using System.Collections.Generic;
using System.Text;

namespace P02_Library
{
  public  class Book
    {
        public Book(string bookId)
        {
            this.Id = bookId;
        }

        public string Id { get; set; }

        public override string ToString()
        {
            return $"Book {this.Id}"; 
        }
    }
}
