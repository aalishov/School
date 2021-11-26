using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        private static List<Tire[]> tires = new List<Tire[]>();
        private static List<Engine> engines = new List<Engine>();
        private static List<Car> cars = new List<Car>();
        public static void Main()
        {
            CreateTires();
            CreateEngines();
            CreateCars();
            foreach (var car in cars)
            {
                Console.WriteLine(car.WhoAmI());
            }
            foreach (var car in cars)
            {
                Console.WriteLine(car.Drive(20));
            }
            foreach (var car in cars)
            {
                Console.WriteLine(car.Drive(1500));
            }
            foreach (var car in cars)
            {
                Console.WriteLine(car.Refuel(50));
            }
            foreach (var car in cars)
            {
                Console.WriteLine(car.WhoAmI());
            }
        }
        public static void CreateCars()
        {
            string info = string.Empty;
            while ((info = Console.ReadLine()) != "Show special")
            {
                List<string> carInfo = info.Split(' ').ToList();
                string make = carInfo[0];
                string model = carInfo[1];
                int year = int.Parse(carInfo[2]);
                double fuelQuantity = double.Parse(carInfo[3]);
                double fuelConsumption = double.Parse(carInfo[4]);
                Tire[] carTires = tires[int.Parse(carInfo[5])];
                Engine engine = engines[int.Parse(carInfo[6])];

                cars.Add(new Car(make, model, year, fuelQuantity, fuelConsumption, engine, carTires));
            }
        }
        public static void CreateEngines()
        {
            string info = string.Empty;
            while ((info = Console.ReadLine()) != "Engines done")
            {
                List<string> engineInfo = info.Split(' ').ToList();
                int horsePower = int.Parse(engineInfo[0]);
                double cubics = double.Parse(engineInfo[1]);
                engines.Add(new Engine(horsePower,cubics));
            }
        }

        public static void CreateTires()
        {
            string info = string.Empty;
            while ((info=Console.ReadLine())!= "No more tires")
            {
                List<string> tiresInfo = info.Split(' ').ToList();
                List<Tire> currentTires = new List<Tire>();

                for (int i = 0; i < tiresInfo.Count; i+=2)
                {
                    int year = int.Parse(tiresInfo[i]);
                    double pressure = double.Parse(tiresInfo[i+1]);
                    currentTires.Add(new Tire(year, pressure));
                }
                tires.Add(currentTires.ToArray());
            }
        }
    }
}
