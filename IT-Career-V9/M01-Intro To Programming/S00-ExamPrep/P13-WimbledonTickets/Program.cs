public class Program
{
    public static void Main()
    {
        string stage = Console.ReadLine();
        string type = Console.ReadLine();
        int tickets = int.Parse(Console.ReadLine());
        string photo = Console.ReadLine();

        double price = 0.0;

        if (stage == "Quarter final ")
        {
            switch (type)
            {
                case "Standard": price = 55.5; break;
                case "Premium": price = 105.2; break;
                case "VIP": price = 118.9; break;
            }
        }
        else if (stage == "Semi final")
        {
            switch (type)
            {
                case "Standard": price = 75.88; break;
                case "Premium": price = 125.22; break;
                case "VIP": price = 300.4; break;
            }
        }
        else
        {
            switch (type)
            {
                case "Standard": price = 110.1; break;
                case "Premium": price = 160.66; break;
                case "VIP": price = 400; break;
            }
        }

        double totalPrice = price * tickets;
        double photoPrice = 0.0;
        if (photo == "Y" && totalPrice <= 4000)
        {
            photoPrice += 40;
        }

        if (totalPrice > 4000)
        {
            totalPrice *= 0.75;
        }
        else if (totalPrice > 2500)
        {
            totalPrice *= 0.9;
        }
        totalPrice += photoPrice;

        Console.WriteLine($"{totalPrice:F2}");
    }
}

