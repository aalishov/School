public class Program
{
    public static void Main()
    {
        //Input
        double breadPrice = double.Parse(Console.ReadLine());
        int breadCount = int.Parse(Console.ReadLine());
        int sweatBreadCount = int.Parse(Console.ReadLine());
        int bagelCount = int.Parse(Console.ReadLine());
        int croissantCount = int.Parse(Console.ReadLine());
        double budget= double.Parse(Console.ReadLine());

        double sweatBreadPrice = breadPrice * 1.2;
        double bagelPrice = sweatBreadPrice * 0.6;
        double croissantPrice = bagelPrice + 1.2;

        double totalPrice = breadPrice * breadCount + sweatBreadPrice * sweatBreadCount + bagelPrice * bagelCount + croissantPrice * croissantCount;

        string money = $"{Math.Abs(totalPrice - budget):f2}";


        //Output
        if (totalPrice<=budget)
        {
            Console.WriteLine($"Yes! {money} leva left.");
        }
        else
        {
            Console.WriteLine($"No!  {money} leva need.");
        }
    }
}

