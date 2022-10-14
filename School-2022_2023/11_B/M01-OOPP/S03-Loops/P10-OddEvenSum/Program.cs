using System;

public class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sumEven = 0;
        int sumOdd = 0;
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (i % 2 == 0) { sumEven += num; }
            else { sumOdd += num; }
        }
        if (sumEven == sumOdd)
        {
            Console.WriteLine("Yes");
            Console.WriteLine($"Sum = {sumOdd}");
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine($"Diff = {(Math.Abs(sumOdd - sumEven))}");
        }
    }
}

