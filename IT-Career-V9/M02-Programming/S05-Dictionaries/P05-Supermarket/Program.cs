public class Program
{
    public static void Main(string[] args)
    {
        Dictionary<string, decimal> prices = new Dictionary<string, decimal>();
        Dictionary<string, int> quantities = new Dictionary<string, int>();

        while (true)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string product = input[0];

            if (product == "stocked") { break; }

            decimal price = decimal.Parse(input[1]);
            int quantity = int.Parse(input[2]);

            if (!prices.ContainsKey(product))
            {
                prices[product] = price;
                quantities[product] = quantity;
            }
            else
            {
                prices[product] = price;
                quantities[product] += quantity;
            }
        }

        decimal grandTotal = 0m;

        foreach (var product in prices)
        {
            decimal total = product.Value * quantities[product.Key];
            grandTotal += total;
            Console.WriteLine($"{product.Key}: ${product.Value} * {quantities[product.Key]} = ${total:f2}");
        }
        Console.WriteLine("------------------------------");
        Console.WriteLine($"Grand Total: ${grandTotal:f2}");
    }
}

