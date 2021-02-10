using System;

public class Program
{
    static void Main()
    {
        Vehicle vehicle = new Vehicle(150,20);
        Console.WriteLine(vehicle);

        Car car = new Car(130, 30);
        Console.WriteLine(car);

        RaceMotorcycle raceMotorcycle = new RaceMotorcycle(180, 8);
        Console.WriteLine(raceMotorcycle);
    }
}

