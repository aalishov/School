using System;


public class Program
{
    static void Main()
    {
        Car c = new Car();
        c.Make = "Opel";
        c.Model = "Astra";
        c.Year = 2018;
        c.FuelConsumption = 8;
        c.FuelQuantity = 22;
        c.Drive(100);
        c.Drive(150);
        c.Drive(50);
        string result = c.WhoAmI();
        Console.WriteLine(result);

    }
}

