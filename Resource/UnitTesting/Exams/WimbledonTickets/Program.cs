public class Program
{
    public static void Main()
    {
        string type = Console.ReadLine();
        string ticket = Console.ReadLine();
        int count = int.Parse(Console.ReadLine());
        char photo = Console.ReadKey().KeyChar; Console.WriteLine();

        double price = 0.0;


        if (type == "Quarter final")
        {
            if (ticket == "Standard")
            { price = 55.5; }
            else if (ticket == "Premium")
            { price = 105.2; }
            else { price = 118.9; }
        }
        else if (type == "Semi final")
        {
            if (ticket == "Standard")
            { price = 75.88; }
            else if (ticket == "Premium")
            { price = 125.22; }
            else { price = 300.4; }

        }
        else
        {
            if (ticket == "Standard")
            { price = 110.1; }
            else if (ticket == "Premium")
            { price = 160.66; }
            else { price = 400; }
        }

        double total = count * price;

        if (total>4000)
        {
            total *= 0.75;
        }
        else if (total>2500)
        {
            total *= 0.9;
            if (true)
            {

            }
        }
    }
}
