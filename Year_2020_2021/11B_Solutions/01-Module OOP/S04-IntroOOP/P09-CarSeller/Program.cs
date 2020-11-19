using System;

public class Program
{
    public static void Main()
    {
        Car car = new Car("BMW X5", new Engine("V4-33",150));
        Console.WriteLine(car);
    }
}

