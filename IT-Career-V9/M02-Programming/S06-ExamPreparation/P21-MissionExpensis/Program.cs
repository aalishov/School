public class Program
{
    private const double Fuel = 500000;
    private const double Oxygen = 200000;
    private const double Food = 50000;
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine() ?? "0");

        double totalPrice = 0;

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine() ?? string.Empty;

            switch (input)
            {
                case "fuel": totalPrice += Fuel; break;
                case "oxygen": totalPrice += Oxygen; break;
                case "food": totalPrice += Food; break;
            }
        }
        Console.WriteLine($"{totalPrice:f2}");
    }
}