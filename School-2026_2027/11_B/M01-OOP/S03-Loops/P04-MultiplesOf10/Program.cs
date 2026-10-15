using System;
public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        while (n % 10 != 0)
        {
            Console.WriteLine("Invalid number!");
            n = int.Parse(Console.ReadLine());

        }
        Console.WriteLine($"The number is: {n}");
    }
}

