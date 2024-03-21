using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14_Success_1._3._16
{
    public class Book
    {
        public Book(string title, string author, double price, string genre)
        {
            Title = title;
            if (string.IsNullOrWhiteSpace(Title)) 
            {
                throw new ArgumentException("Invalid title");
            }
            Author = author;
            Price = price;
            if (price<=0) 
            {
                throw new ArgumentException("Price can not be 0 or negative.");
            }
            Genre = genre;
        }

        public string Title { get; private set; }

        public string Author { get; private set; }

        public double Price { get; private set; }

        public string Genre { get; private set; }

        public override string ToString()
        {
            
            return $"{Title} от {Author}, {Price:f2}";
        }
    }
}
