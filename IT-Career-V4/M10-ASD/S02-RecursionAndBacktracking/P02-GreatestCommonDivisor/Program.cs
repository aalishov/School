using System;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("a [Sample: 35]=");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b [Sample: 14]=");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Greatest Common Divisor [Sample: 7] = {0}", Gcd(a, b)); // gcd = 7
    }

    // Рекурсивен метод за намиране на най-голям общ делител
    private static int Gcd(int a, int b)
    {
        if (a == b) return a;
        if (a > b) return Gcd(a - b, b);
        else return Gcd(a, b - a);
    }
}

