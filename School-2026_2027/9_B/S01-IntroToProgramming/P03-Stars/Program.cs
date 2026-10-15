using System;
public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        //First row
        Console.WriteLine(new string('*', n));

        for (int i = 0; i < n-2; i++)
        {
            Console.WriteLine($"*{new string(' ',n-2)}*");
        }

        //Last row
        Console.WriteLine(new string('*', n));
    }
}