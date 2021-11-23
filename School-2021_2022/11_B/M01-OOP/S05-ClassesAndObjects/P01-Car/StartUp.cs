using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            Car car = new Car("VW","MK3",1992);
            //car.Make = "VW";
            //car.Model = "MK3";
            //car.Year = 1992;
            Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");
        }
    }
}
