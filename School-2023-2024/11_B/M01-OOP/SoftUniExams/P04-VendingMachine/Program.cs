namespace P04_VendingMachine
{
    public class Program
    {
        public static void Main()
        {
            Drink d1 = new Drink("Cola", 1.30m, 330);
            Drink d2 = new Drink("Coffee", 1.40m, 100);
            Drink d3 = new Drink("Fanta", 1.35m, 330);
            Drink d4 = new Drink("Sprite", 1.80m, 330);

            VendingMachine v1 = new VendingMachine(5);
            v1.AddDrink(d1);
            v1.AddDrink(d2);
            v1.AddDrink(d3);
            v1.AddDrink(d4);
            Console.WriteLine(v1.Report());

        }
    }
}