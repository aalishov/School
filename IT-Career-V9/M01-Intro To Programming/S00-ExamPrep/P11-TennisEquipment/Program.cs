public class Program
{
    public static void Main()
    {
        double priceRacket = double.Parse(Console.ReadLine());
        int countRacket = int.Parse(Console.ReadLine());
        int countTrainers = int.Parse(Console.ReadLine());

        double totalPriceRacket = countRacket * priceRacket;
        double totalPriceTrainers = countTrainers * (priceRacket * 1.0 / 6.0);
        double totalPriceEquipment = (totalPriceRacket + totalPriceTrainers) * 0.2;
        double totalPrice = totalPriceRacket + totalPriceTrainers + totalPriceEquipment;

        double djoko = Math.Floor(totalPrice / 8.0);
        double sponsors = Math.Ceiling(totalPrice * 7.0 / 8.0);

        Console.WriteLine($"Price to be paid by Djokovic {djoko}");
        Console.WriteLine($"Price to be paid by sponsors {sponsors}");
    }
}

