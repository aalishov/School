using System;

namespace P11_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "I live in Velingrad";
            Console.WriteLine(text.Substring(2));
            Console.WriteLine(text.Substring(2,4));
            string word = "Velingrad";
            int startIndex = text.IndexOf(word);
            Console.WriteLine(text.Substring(startIndex,word.Length));
        }
    }
}
