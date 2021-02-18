using System;

class Program
{
    static void Main()
    {
        int n = 15;
        int result = FibRecursion(n);
        Console.WriteLine(result);
        PrintFibonacci();
    }

    public static int FibRecursion(int n)
    {
        if (n == 1 || n == 2)
        {
            return 1;
        }

        return FibRecursion(n - 1) + FibRecursion(n - 2);
    }

    public static void PrintFibonacci()
    {
        int first = 1;
        int second = 1;
        Console.WriteLine(first);
        Console.WriteLine(second);

        for (int i = 0; i < 15; i++)
        {
            int result = first + second;
            Console.WriteLine(result);
            first = second;
            second = result;
        }
    }
}

