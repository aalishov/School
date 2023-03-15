using System;

public class Program
{
    public static void Main()
    {

        for (int i = 'a'; i <= 'z'; i++)
        {
            Console.WriteLine($"{i} => {(char)i}");
        }
    }
}

