using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        PrintHeader();
        PrintHeader(20);
        PrintHeader('&');
        PrintHeader('%',5);
    }

    static void PrintHeader()
    {
        Console.WriteLine(new string('-', 15));
    }
    static void PrintHeader(int n)
    {
        Console.WriteLine(new string('-', n));
    }
    static void PrintHeader(char c)
    {
        Console.WriteLine(new string(c, 15));
    }
    static void PrintHeader(char c, int n)
    {
        Console.WriteLine(new string(c, n));
    }

    static double GetSquareArea(double a)
    {
        if (a > 0)
        {
            return a * a;
        }
        throw new InvalidOperationException("Square side must be positive!");
    }

    static double GetRectangleArea(double a, double b)
    {
        PrintHeader();
        if (a > 0 && b > 0)
        {
            return a * b;
        }
        throw new InvalidOperationException("Rectangle sides must be positive!");
    }
}

