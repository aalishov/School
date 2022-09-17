using System;
using System.Reflection;

namespace IteratorsAndComparators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("Book 1", 2022);
            Book b2 = new Book("Book 2", 2022);
            //Console.WriteLine(b1.CompareTo(b2));
            //Console.WriteLine(new BookComparator().Compare(b1,b2));
            Type type = typeof(Book);

            Type[] interfaces = type.GetInterfaces();
            foreach (var item in interfaces)
            {
                Console.WriteLine(item);
            }


        }
    }
}
