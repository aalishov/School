public class Program
{
    private const double Calendula = 5.0;
    private const double Zinnia = 4.0;
    private const double Callistephus = 6.0;
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine() ?? "0");

        double price = 0.0;

        for (int i = 0; i < n; i++)
        {
            string flower = Console.ReadLine() ?? "0";
            switch (flower)
            {
                case "calendula": price += Calendula; break;
                case "zinnia": price += Zinnia; break;
                case "callistephus": price += Callistephus; break;
            }
        }
        Console.WriteLine($"{price:f2}");
    }
}

