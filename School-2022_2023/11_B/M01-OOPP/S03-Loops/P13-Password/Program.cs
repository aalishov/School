using System;

namespace P13_Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name=Console.ReadLine();
            string password=Console.ReadLine();
            string enterPass=Console.ReadLine();
            while (password!=enterPass)
            {
                enterPass = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {name}!");
        }
    }
}
