using System;

namespace P01_ComparePeoples
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person p1 = new Person() { Name = "Pesho", Age = 8 };
            Person p2 = new Person() { Name = "Gosho", Age = 12 };

            Console.WriteLine(p1.CompareTo(p2));
        }
    }
}
