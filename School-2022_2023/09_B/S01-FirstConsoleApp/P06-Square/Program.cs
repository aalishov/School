using System;

public class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        //First now
        Console.WriteLine(new String('*', n));

        //Middle rows
        for (int i = 0; i < n - 2; i++)
        {
            Console.WriteLine($"*{new String(' ', n - 2)}*");
        }

        //Last row
        Console.WriteLine(new String('*', n));
    }
}