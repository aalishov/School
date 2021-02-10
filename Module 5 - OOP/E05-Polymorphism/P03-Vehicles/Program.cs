using System;

namespace P03_Vehicles
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine().Split(' ');
            string[] truckInfo = Console.ReadLine().Split(' ');
            int cmdCounter = int.Parse(Console.ReadLine());

            double carFuel = double.Parse(carInfo[1]);
            double truckFuel = double.Parse(truckInfo[1]);
            double carConsumption = double.Parse(carInfo[2]);
            double truckConsumption = double.Parse(truckInfo[2]);

            Car car = new Car(carFuel, carConsumption);
            Truck truck = new Truck(truckFuel, truckConsumption);

            for (int i = 0; i < cmdCounter; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                string cmd = line[0];
                string type = line[1];
                double value = double.Parse(line[2]);

                switch (cmd)
                {
                    case "Drive":
                        if (type=="Car")
                        {
                            Console.WriteLine(car.Drive(value));
                            Console.WriteLine(car);
                        }
                        else
                        {
                            Console.WriteLine(truck.Drive(value));
                            Console.WriteLine(truck);
                        }
                        break;
                    case "Refuel":
                        if (type == "Car")
                        {
                            Console.WriteLine(car.Refuel(value));
                            Console.WriteLine(car);
                        }
                        else
                        {
                            Console.WriteLine(truck.Refuel(value));
                            Console.WriteLine(truck);
                        }
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
