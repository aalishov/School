public class Program
{
    public static void Main()
    {
        string product = Console.ReadLine();
        string town = Console.ReadLine();
        int count = int.Parse(Console.ReadLine());

        double price = 0.0;

        switch (product)
        {
            case "coffee":
                if (town == "Sofia") { price = 0.50; }
                else if (town == "Plovdiv") { price = 0.40; }
                else if(town == "Varna") { price = 0.45; }
                break;
            case "water":
                if (town == "Sofia") { price = 0.80; }
                else if (town == "Plovdiv" || town == "Varna") { price = 0.70; }
                break;
            case "beer":
                if (town == "Sofia") { price = 1.20; }
                else if (town == "Plovdiv") { price = 1.15; }
                else if (town == "Varna") { price = 1.10; }
                break;
            case "sweets":
                break;
            case "peanuts":
                break;
        }

        double totalPrice = count * price;
        Console.WriteLine(totalPrice);
    }
}

