using System;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        //First row
        Console.Write("+ ");
        for (int i = 0; i < n-2; i++)
        {
            Console.Write("- ");
        }
        Console.WriteLine("+");


        //Middle rows
        for (int i = 0; i < n-2; i++)
        {
            Console.Write("| ");
            for (int j = 0; j < n - 2; j++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("|");
        }

        //Last row
        Console.Write("+ ");
        for (int i = 0; i < n - 2; i++)
        {
            Console.Write("- ");
        }
        Console.WriteLine("+");
    }
}

