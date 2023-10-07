using System;

public class Program
{
    public static void Main()
    {
        Print(5);
    }

    public static void Print(int n)
    {
        if (n == 0) { return; }

        Console.WriteLine(n);

        Print(n - 1);

        Console.WriteLine(n);
    }
}
