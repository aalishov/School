using System;

class Program
{
    static void Main()
    {
        string month = Console.ReadLine();
        int nights = int.Parse(Console.ReadLine());

        double apartmentPrice = 0.0;
        double studioPrice = 0.0;
        double studioDiscount = 0;

        double apartmentDiscount = nights > 14 ? 10 : 0;

        //if (nights > 14)
        //{
        //    apartmentDiscount = 10;
        //}

        switch (month)
        {
            case "May":
            case "October":
                apartmentPrice = 65;
                studioPrice = 50;

                if (nights > 14)
                {
                    studioDiscount = 30;
                }
                else if (nights > 7)
                {
                    studioDiscount = 5;
                }

                break;
            case "June":
            case "September":
                apartmentPrice = 68.7;
                studioPrice = 75.2;

                studioDiscount = nights > 14 ? 20 : 0;
                //if (nights > 14)
                //{
                //    studioDiscount = 20;
                //}
                break;
            case "July":
            case "August":
                apartmentPrice = 77;
                studioPrice = 76;
                break;
            default:
                break;
        }

        double totalApartmentPrice = nights * (apartmentPrice - apartmentPrice * apartmentDiscount / 100);
        double totalStudioPrice = nights * (studioPrice - studioPrice * studioDiscount / 100);

        Console.WriteLine($"Apartment: {totalApartmentPrice:f2} lv.");
        Console.WriteLine($"Studio: {totalStudioPrice:f2} lv.");
    }
}

