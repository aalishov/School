using System;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int gasolineCounter = 0;
        int dieselCounter = 0;

        for (int i = 0; i < n; i++)
        {
            string model = Console.ReadLine();
            string carType = Console.ReadLine();
            string fuel = Console.ReadLine();
            string status = Console.ReadLine();
            decimal price = decimal.Parse(Console.ReadLine());
            int km = int.Parse(Console.ReadLine());

            string category = string.Empty;
            if (carType == "coupe" && fuel == "gasoline")
            {
                gasolineCounter++;
                category = "sport";
                if (price > 100000)
                {
                    category = "supersport";
                }
            }
            else if (carType == "coupe" && fuel == "diesel")
            {
                dieselCounter++;
                category = "ecosport";
            }
            else if (carType == "sedan" && fuel == "gasoline")
            {
                gasolineCounter++;
                category = "executive";
                if (price > 80000)
                {
                    category = "limousine";
                }
            }
            else
            {
                dieselCounter++;
                category = "economic";
            }

            if (status == "vip")
            {
                price += 200;
            }

            Console.WriteLine($"Car model - {model}");
            Console.WriteLine($"Category - {category}");
            Console.WriteLine($"Type - {carType}");
            Console.WriteLine($"Fuel - {fuel}");
            Console.WriteLine($"Kilometers - {km}");
            Console.WriteLine($"Price - {price:f2}");
        }

        Console.WriteLine($"Gasoline cars: {gasolineCounter / (double)n * 100.0:f2}%");
        Console.WriteLine($"Diesel cars: {dieselCounter / (double)n * 100.0:f2}% ");
    }
}

