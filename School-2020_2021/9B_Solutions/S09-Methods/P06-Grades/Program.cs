using System;

public class Program
{
    public static void Main(string[] args)
    {
        string result = Grade(double.Parse(Console.ReadLine()));
        Console.WriteLine(result);
    }

    public static string Grade(double grade)
    {
        if (grade <= 2.99) { return "Fail"; }
        else if (grade < 3.5) { return "Poor"; }
        else if (grade < 4.5) { return "Good"; }
        else if (grade < 5.5) { return "Very good"; }
        else { return "Excellent"; }
    }
}

