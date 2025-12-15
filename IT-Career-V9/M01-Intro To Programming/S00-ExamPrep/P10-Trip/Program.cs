public class Program
{
    public static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        string season = Console.ReadLine();

        string destination = string.Empty;
        string place=string.Empty;
        double price = 0.0;

        if (budget <= 100)
        {
            destination = "Bulgaria";
            if (season =="summer")
            {
                place = "Camp";
                price= budget*0.3;
            }
            else
            {
                place = "Hotel";
                price = budget * 0.7;
            }
        }
        else if (budget>100&&budget<=1000)
        {
            destination = "Balkans";
            if (season == "summer")
            {
                place = "Camp";
                price = budget * 0.4;
            }
            else
            {
                place = "Hotel";
                price = budget * 0.8;
            }
        }
        else
        {
            destination = "Europe";
            place = "Hotel";
            price = budget * 0.9;
        }

        Console.WriteLine($"Somewhere in {destination}");
        Console.WriteLine($"{place} - {price:f2}");
    }
}

