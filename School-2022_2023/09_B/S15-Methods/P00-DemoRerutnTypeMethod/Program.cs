using System;

public class Program
{
    public static void Main()
    {
        string result = IsEvenOrOdd(19);
        Console.WriteLine(result);
    }
    public static string IsEvenOrOdd(int num)
    {
        if (IsEven(num))
        {

            return $"Number {num} is even!";
        }
        else
        {
            return $"Number {num} is odd!";
        }
    }

    public static bool IsEven(int num)
    {
        if (num % 2 == 0) { return true; }
        else { return false; }
    }

    public static int AddOne(int number)
    {
        number += 1;
        return number;
    }
}