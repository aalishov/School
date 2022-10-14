using System;

public class Program
{
    static void Main(string[] args)
    {
        int n=int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i+=2)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Num: {num*i}");
        }
    }
}

