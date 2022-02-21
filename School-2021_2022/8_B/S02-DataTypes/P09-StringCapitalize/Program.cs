using System;

namespace P09_StringCapitalize
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter text: ");
            string info = Console.ReadLine();

            Console.WriteLine(info.ToUpper());
            Console.WriteLine(info.ToLower());
        }
    }
}
