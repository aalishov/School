using System;

namespace Vehicles
{
    public class Program
    {
        public static void Main()
        {
            string[] carInfo = Console.ReadLine().Split(' ');
            Vehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]));
            string[] truckInfo = Console.ReadLine().Split(' ');
            Vehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(truckInfo[3]));
            string[] busInfo = Console.ReadLine().Split(' ');
            Vehicle bus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3]));

            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                try
                {
                    string[] input = Console.ReadLine().Split(' ');
                    string cmd = input[0];
                    string type = input[1];

                    if (cmd == "Drive")
                    {
                        double distance = double.Parse(input[2]);
                        if (type == "Car") { Console.WriteLine(car.Drive(distance)); }
                        else if (type == "Bus")
                        {
                            ((Bus)bus).HasPassangers = true;
                            Console.WriteLine(bus.Drive(distance));
                        }
                        else { Console.WriteLine(truck.Drive(distance)); }
                    }
                    else if (cmd == "DriveEmpty")
                    {
                        double distance = double.Parse(input[2]);
                        ((Bus)bus).HasPassangers = false;
                        Console.WriteLine(bus.Drive(distance));
                    }
                    else
                    {
                        double refuelQuantity = double.Parse(input[2]);
                        if (type == "Car") { car.Refuel(refuelQuantity); }
                        else if (type == "Bus") { bus.Refuel(refuelQuantity); }
                        else { truck.Refuel(refuelQuantity); }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
              
            }
            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }
    }
}
