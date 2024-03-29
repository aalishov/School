public class Program
{
    public static void Main()
    {
        double priceOver20 = double.Parse(Console.ReadLine());
        double weight = double.Parse(Console.ReadLine());
        int daysUntilTrip = int.Parse(Console.ReadLine());
        int numOfLuggage = int.Parse(Console.ReadLine());

        double price = 0;
        if (weight < 10)
        {
            price = priceOver20 * 0.2;

        }
        else if (weight >= 10 && weight <= 20)
        {
            price = priceOver20 * 0.5;
        }
        else
        {
            price = priceOver20;
        }

        if (daysUntilTrip>30)
        {
            price *= 1.1;
        }
        else if (daysUntilTrip>=7 &&daysUntilTrip<=30)
        {
            price *= 1.15;
        }
        else
        {
            price *= 1.4;
        }
        Console.WriteLine($"The total price of bags is: {numOfLuggage*price:f2} lv.");
    }
}
