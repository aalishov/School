using System;

public class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        for (int i = 0; i < input.Length; i++)
        {
            Console.WriteLine($"{(char)input[i]} -> {input[i] - 97}");
        }
    }
}

