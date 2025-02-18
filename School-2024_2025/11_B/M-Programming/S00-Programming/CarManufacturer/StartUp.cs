using CarManufacturer;

namespace _01_CarManufacturer
{
    public class StartUp
    {
        public static void Main()
        {
            Car car = new Car();
            car.Make = "Audi";
            car.Model = "A8";
            car.Year = 2024;
            car.FuelConsumption = 10;
            car.FuelQuantity = 30;
            car.Drive(400);
            Car car1 = new Car()
            {
                Make = "Audi",
                Model = "A6",
                Year = 2024,
            };
            Car car4 = new Car();
            Car car5 = new Car("BMW", "X6", 2017);

            Car car2 = new Car("BMW", "X6", 2015, 15, 10);
            Car car3 = new Car("BMW", "X5" );
            Console.WriteLine(car5.WhoAmI());

            List<Tire> tires = new List<Tire>() { 
            new Tire(1 , 2.5), new Tire(1, 2.1), new Tire(2, 0.5), new Tire(2, 2.3),
            };

            Engine engine = new Engine(560, 6300);
            Car car9 = new Car("Lamborghini", "Urus", 2010, 250, 9, engine, tires);

        }
    }
}
