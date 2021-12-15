using System;

namespace P10_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "I live in Velingrad";

            Console.WriteLine(text.IndexOf("live"));
            Console.WriteLine(text.IndexOf("in"));
            Console.WriteLine(text.IndexOf("Sofia"));
            Console.WriteLine(text.LastIndexOf("live"));
            Console.WriteLine(text.LastIndexOf("in"));
        }
    }
}
