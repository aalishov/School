using System;

namespace P25_DemoConsoleWrite_v3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "John";
            string town = "London";

            Console.WriteLine($"{"Name",-10}{"Town",-10}");
            Console.WriteLine($"{name,-10}{town,-10}");
            Console.WriteLine(new string('-',15));
            Console.WriteLine($"{"Name",10}{"Town",10}");
            Console.WriteLine($"{name,10}{town,10}");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i,3} x {"5",3} = {i*5,3}");
            }

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i,3} x {"6",2} = {i * 6,3}");
            }
        }
    }
}
