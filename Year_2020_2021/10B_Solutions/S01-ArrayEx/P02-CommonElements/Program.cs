using System;
using System.Linq;

namespace P02_CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first arr: ");
            string[] first = Console.ReadLine()
                .Split(' ')
                .ToArray();
            Console.Write("Enter second arr: ");
            string[] second = Console.ReadLine()
                .Split(' ')
                .ToArray();

            string commonElements = string.Empty;

            foreach (var f in first.Distinct())
            {
                foreach (var s in second.Distinct())
                {
                    if (f==s)
                    {
                        commonElements += s + " ";
                    }
                }
            }

            Console.WriteLine($"Common elements: {commonElements}");
        }
    }
}
