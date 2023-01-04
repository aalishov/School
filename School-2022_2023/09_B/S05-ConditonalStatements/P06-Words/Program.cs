using System;

public class Program
{
   public static void Main()
    {
        string first = Console.ReadLine().ToLower();
        string second = Console.ReadLine().ToLower();
        if (first==second)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}

