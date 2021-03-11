using System;

class Program
{
    static void Main()
    {
        decimal budget = decimal.Parse(Console.ReadLine());
        string season = Console.ReadLine();


        string destination = string.Empty;
        string place = string.Empty;
        decimal expenses = 0.0m;

        if (budget <= 100)
        {
            destination = "Bulgaria";
            if (season=="summer")
            {
                place = "Camp";
                expenses = budget * 30 / 100;
            }
            else
            {
                place = "Hotel";
                expenses = budget * 70 / 100;
            }
        }
        else if (budget > 100 && budget <= 1000)
        {
            destination = "Balkans";
            if (season == "summer")
            {
                place = "Camp";
                expenses = budget * 40 / 100;
            }
            else
            {
                place = "Hotel";
                expenses = budget * 80 / 100;
            }
        }
        else
        {
            destination = "Europe";
            place = "Hotel";
            expenses = budget * 90 / 100;
        }

        Console.WriteLine($"Somewhere in {destination}");
        Console.WriteLine($"{place} - {expenses:f2}");
    }
}

