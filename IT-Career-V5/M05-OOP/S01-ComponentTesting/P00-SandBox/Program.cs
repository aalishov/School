using System;
using System.Globalization;

public class Program
{
    static void Main()
    {
        string input = Console.ReadLine();//05:55

        DateTime time = DateTime.ParseExact(input, "HH:mm", CultureInfo.InvariantCulture);

        DateTime newTime = time.AddMinutes(15);
        Console.WriteLine(newTime.ToString("HH:mm"));
    }
}

