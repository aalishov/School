public class Program
{
    public static void Main()
    {
        Dictionary<string, int> resources = new Dictionary<string, int>();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "stop")
            {
                foreach (var item in resources)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }
                Environment.Exit(0);
            }
            int quantity = int.Parse(Console.ReadLine());
            if (resources.ContainsKey(input))
            {
                input += quantity;
            }
            else
            {
                resources.Add(input, quantity);
            }
        }
    }
}

