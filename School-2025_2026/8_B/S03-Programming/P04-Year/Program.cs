public class Program
{
    public static void Main()
    {
        double production = 130;
        int year = 2026;
        while (production >= 10)
        {
            production*= 0.9; // Decrease production by 10% each year
            year++;
        }
        Console.WriteLine($"The production will drop below 10 units in the year {year}.");
    }
}

