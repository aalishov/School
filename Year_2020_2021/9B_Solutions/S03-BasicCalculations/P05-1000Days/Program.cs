using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        string readeDate = Console.ReadLine();

        DateTime date = new DateTime();

        bool isConver = DateTime.TryParseExact(readeDate, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date);

        Console.WriteLine(date.AddDays(999).ToString("dd-MM-yyyy"));
    }
}

