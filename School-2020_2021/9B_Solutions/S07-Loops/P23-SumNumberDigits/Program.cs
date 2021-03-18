using System;

class Program
{
    static void Main()
    {
        string numAsString = Console.ReadLine();
        int num = int.Parse(numAsString);
        int sum = 0;
        for (int i = 0; i < numAsString.Length; i++)
        {
            int lastDigit = num % 10;
            sum += lastDigit;
            num /= 10;
        }
        Console.WriteLine($"{sum}");
    }
}

