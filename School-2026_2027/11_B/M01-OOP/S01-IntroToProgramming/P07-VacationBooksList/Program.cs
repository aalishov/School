using System;

public class Program
{
    public static void Main()
    {
        int numberOfPages = int.Parse(Console.ReadLine());
        double pagesPerHour = double.Parse(Console.ReadLine());
        int numberOfDays = int.Parse(Console.ReadLine());
        double totalHours = numberOfPages / pagesPerHour;
        double hoursPerDay = totalHours / numberOfDays;

        Console.WriteLine($"{hoursPerDay}");
    }
}

