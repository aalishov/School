public class Program
{
    public static void Main()
    {
        string name = Console.ReadLine();
        int countAdults = int.Parse(Console.ReadLine());
        int countKids = int.Parse(Console.ReadLine());     
        double priceForAdults = double.Parse(Console.ReadLine());
        double tax = double.Parse(Console.ReadLine());
        double priceForKids = priceForAdults - (priceForAdults * 0.7) ;

        double sum = (countKids * (priceForKids +tax)) + (countAdults * (priceForAdults + tax));

        Console.WriteLine($"The profit of your agency from {name} tickets is {sum*0.2:f2} lv.");

    }
}

