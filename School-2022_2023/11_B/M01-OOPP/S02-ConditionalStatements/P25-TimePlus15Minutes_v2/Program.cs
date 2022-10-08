using System;
using System.Globalization;

public class Program
{
    static void Main(string[] args)
    {
        string hour = Console.ReadLine();
        string  minutes = Console.ReadLine();

        DateTime dateTime ;
        bool isParse = DateTime.TryParseExact($"{hour}:{minutes}", "H:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime);

        var newDate= dateTime.AddMinutes(15);

        Console.WriteLine(newDate.ToString("H:mm"));
    }
}

