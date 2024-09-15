using System;

internal class Program
{
    // Рекурсивен метод за намиране на фибоначи
    static int Fib(int n)
    {
        if (n == 1 || n == 2) return 1;
        else return Fib(n - 2) + Fib(n - 1);
    }

    static void Main(string[] args)
    {
        Console.Write("N=");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Fib(n));
    }
}

