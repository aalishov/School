public class Program
{
    const decimal MayOctoberStudio = 50m;
    const decimal MayOctoberApartment = 65m;
    const decimal JuneSeptemberStudio = 75.20m;
    const decimal JuneSeptemberApartment = 68.70m;
    const decimal JulyAugustStudio = 76m;
    const decimal JulyAugustApartment = 77m;
    public static void Main()
    {
        //Input
        string month = Console.ReadLine();
        int days = int.Parse(Console.ReadLine());

        //Action
        decimal priceStudio = 0.0m;
        decimal priceApartment = 0.0m;
        switch (month)
        {
            case "May":
            case "October":
                priceStudio = MayOctoberStudio;
                if (days > 7 && days <= 14) { priceStudio *= 0.95m; }
                else if (days > 14) { priceStudio *= 0.7m; }
                priceApartment = MayOctoberApartment;
                break;
            case "June":
            case "September":
                priceStudio = JuneSeptemberStudio;
                if (days > 14) { priceStudio *= 0.8m; }
                priceApartment = JuneSeptemberApartment;
                break;
            case "July":
            case "August":
                priceStudio = JulyAugustStudio;
                priceApartment = JulyAugustApartment;
                break;
        }
        if (days>14){ priceApartment *= 0.9m; }

        decimal totalPriceStudio = days * priceStudio;
        decimal totalPriceApartment=days * priceApartment;

        //Output
        Console.WriteLine($"Apartment: {totalPriceApartment:f2} lv.");
        Console.WriteLine($"Studio: {totalPriceStudio:f2} lv.");
    }
}

