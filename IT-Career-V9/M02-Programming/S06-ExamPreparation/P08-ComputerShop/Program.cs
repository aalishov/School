
public class Program
{
    public static void Main()
    {
        double totalPrice = 0;

        while (true)
        {
            string input = Console.ReadLine() ?? string.Empty;
            if (input == "special" || input == "regular")
            {
                if (totalPrice != 0) {
                    double taxes = totalPrice * 0.20;
                    Console.WriteLine("Congratulations you've just bought a new computer!");
                    Console.WriteLine($"Price without taxes: {totalPrice:f2}$");
                    Console.WriteLine($"Taxes: {taxes:f2}$");
                    totalPrice *= 1.20;

                    if (input == "special") { totalPrice *= 0.90; }
                    Console.WriteLine("-----------");
                    Console.WriteLine($"Total price: {totalPrice:f2}$");
                    break;
                }else { Console.WriteLine("Invalid order!"); return; }
            }
            double price = double.Parse(input);
            if (price < 0) { Console.WriteLine("Invalid price!"); }
            else { totalPrice += price; }
        }
    }
}