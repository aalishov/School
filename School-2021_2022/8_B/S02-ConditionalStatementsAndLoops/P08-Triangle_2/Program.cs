using System;

public class Program
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = n; i >= 1; i--)
        {
            Console.WriteLine(new string('*', i));
        }
    }
}
