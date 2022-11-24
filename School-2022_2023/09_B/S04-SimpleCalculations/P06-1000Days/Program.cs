using System;
using System.Globalization;

public class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        DateTime inputDate = DateTime.ParseExact(input, "dd-MM-yyyy", CultureInfo.InvariantCulture);
        DateTime newDate = inputDate.AddDays(1000);
        Console.WriteLine(newDate.ToString("dd-MM-yyyy"));
    }
}

