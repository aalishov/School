using System;

public class Program
{
    public static void Main()
    {
        decimal a = decimal.Parse(Console.ReadLine());
        decimal b = decimal.Parse(Console.ReadLine());

        decimal area = a * b;
        Console.WriteLine(area);
    }
}

