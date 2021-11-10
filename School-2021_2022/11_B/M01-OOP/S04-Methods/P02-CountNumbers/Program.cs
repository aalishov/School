using System;

class Program
{
    static void Main()
    {
        int evenNumbers = 0;
        int oddNumbers = 0;
        int positiveNumbers = 0;
        int negativeNumbers = 0;
        int zero = 0;

        string cmd = string.Empty;
        Console.Write("Enter number: ");
        while ((cmd = Console.ReadLine()) != "end")
        {
            int num = int.Parse(cmd);

            CountPositiveNegativeAndZero(ref positiveNumbers, ref negativeNumbers,ref zero, num);
            CountEven(ref evenNumbers, num);
            CountOdd(ref oddNumbers, num);

            Console.Write("Enter number: ");
        }

        Console.WriteLine($"Even numbers: {evenNumbers}");
        Console.WriteLine($"Odd numbers: {oddNumbers}");
        Console.WriteLine($"Positive numbers: {positiveNumbers}");
        Console.WriteLine($"Negative numbers: {negativeNumbers}");
        Console.WriteLine($"Zero: {zero}");
    }

    public static void CountEven(ref int count, int num)
    {
        if (num % 2 == 0)
        {
            count++;
        }
    }
    public static void CountOdd(ref int count, int num)
    {
        if (num % 2 != 0)
        {
            count++;
        }
    }
    public static void CountPositiveNegativeAndZero(ref int positiveCount,ref int negativeCount,ref int zeroCount, int num)
    {
        if (num > 0) { positiveCount++; }
        else if (num < 0) { negativeCount++; }
        else { zeroCount++; }
    }
}

