using System;

public class Program
{
    public static void Main()
    {
        string firstString = Console.ReadLine().ToLower();
        string secondString = Console.ReadLine().ToLower();

        while (secondString.IndexOf(firstString) != -1)
        {
            int toBeRemoved = secondString.IndexOf(firstString);
            secondString = secondString.Remove(toBeRemoved, firstString.Length);
        }
        Console.WriteLine(secondString);
    }
}

