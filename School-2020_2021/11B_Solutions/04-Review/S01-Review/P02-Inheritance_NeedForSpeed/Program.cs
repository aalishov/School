using System;

class Program
{
    static void Main(string[] args)
    {
        RaceMotorcycle motorcycle = new RaceMotorcycle("Honda", "A", 150, 20);
        motorcycle.Drive(3);
        Console.WriteLine(motorcycle.Fuel);
    }
}

