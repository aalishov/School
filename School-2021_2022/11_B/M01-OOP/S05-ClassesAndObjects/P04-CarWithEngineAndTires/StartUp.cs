using System;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main()
        {
            Tire[] tires = new Tire[]
            {
                new Tire(2020,2.5),
                new Tire(2020,2.5),
                new Tire(2018,2.3),
                new Tire(2018,2.1)
            };
            Engine engine = new Engine(300, 3500);

            Car car1 = new Car("Audi", "A6", 2018, 150, 8, engine, tires);
        }
    }
}
