public class Program
{
    public static void Main()
    {
        int decorationPrice = int.Parse(Console.ReadLine());
        double pizzaPrice = 2 * decorationPrice;
        double drinksPrice = pizzaPrice * 0.85;
        double gamesPrice = (pizzaPrice + drinksPrice) / 7.0;

        double totalPrice = decorationPrice + pizzaPrice + drinksPrice + gamesPrice;
        Console.WriteLine($"{totalPrice:f2}");
    }
}

