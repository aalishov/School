using System;

public class Program
{
    static void Main()
    {
        int m = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Mult(m, n));
    }
    public static int Mult(int m, int n)
    {
        if (n == 0) { return 0; }
        else if (n < 0) { return Mult(m, n + 1) - m; }
        else { return Mult(m, n - 1) + m; }
    }
}

