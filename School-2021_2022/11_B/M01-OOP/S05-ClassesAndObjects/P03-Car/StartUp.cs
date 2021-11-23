using System;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main()
        {
            Car car1 = new Car("Audi", "A6", 2018,150,8);
            Console.WriteLine(car1.FuelConsumption);
        }
    }
}
