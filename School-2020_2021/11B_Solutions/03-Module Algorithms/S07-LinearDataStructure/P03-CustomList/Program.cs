using System;
using System.Collections.Generic;

namespace P03_CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> numbers = new MyList<int>() { 3, 15, 5, 8 };
            MyList<string> s = new MyList<string>() { "one", "two", "three", "four" };

            numbers.ShiftRight(3);
            Console.WriteLine(string.Join(", ", numbers));
            s.ShiftRight(5);
            Console.WriteLine(string.Join(", ", s));
        }


    }
}
