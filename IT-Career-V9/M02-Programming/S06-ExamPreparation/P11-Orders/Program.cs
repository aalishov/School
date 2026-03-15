public class Program
{
    public static void Main()
    {
        Dictionary<string, double> prices = new Dictionary<string, double>();
        Dictionary<string, int> quantities = new Dictionary<string, int>();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "buy")
            {
                break;
            }
            string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string product = parts[0];
            double price = double.Parse(parts[1]);
            int quantity = int.Parse(parts[2]);
            if (!prices.ContainsKey(product))
            {
                prices[product] = price;
                quantities[product] = quantity;
            }
            else
            {
                prices[product] = price; // Update the price to the latest
                quantities[product] += quantity; // Add to the existing quantity
            }
        }
        foreach (var p in prices)
        {
            Console.WriteLine($"{p.Key} -> {p.Value * quantities[p.Key]:f2}");
        }
    }
}