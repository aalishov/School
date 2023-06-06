using System;

public class Program
{
    public static void Main()
    {
        Car car = new Car();
        car.Brand = "Audi";
        car.Model = "A6";
        car.Year = 2019;

        Console.WriteLine(car);
    }
}