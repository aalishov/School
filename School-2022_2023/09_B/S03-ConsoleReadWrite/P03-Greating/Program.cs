using System;

public class Program
{
    public static void Main()
    {
        string name = Console.ReadLine();
        string result = $"Hello, {name}!";
        Console.WriteLine(result);

        //Вариант 2
        //string name = Console.ReadLine();
        //Console.WriteLine($"Hello, {name}!");

        //Вариант 3
        //Console.WriteLine($"Hello, {Console.ReadLine()}!");

        //Вариант 4
        //Console.WriteLine($"Hello, {0}!",Console.ReadLine());

        //Вариант 5
        //string name = Console.ReadLine();
        //Console.WriteLine("Hello, {0}!",name);
    }
}
