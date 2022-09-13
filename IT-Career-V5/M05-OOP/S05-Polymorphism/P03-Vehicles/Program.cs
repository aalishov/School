using System;

namespace Vehicles
{
    public class Program
    {
        public static void Main()
        {
            string[] carInfo = Console.ReadLine().Split(' ');
            Vehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]));
            string[] truckInfo = Console.ReadLine().Split(' ');
            Vehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]));

            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string cmd = input[0];
                string type = input[1];

                if (cmd == "Drive")
                {
                    double distance = double.Parse(input[2]);
                    if (type == "Car") { Console.WriteLine(car.Drive(distance)); }
                    else { Console.WriteLine(truck.Drive(distance)); }
                }
                else
                {
                    double refuelQuantity = double.Parse(input[2]);
                    if (type == "Car") { car.Refuel(refuelQuantity); }
                    else { truck.Refuel(refuelQuantity); }
                }
            }
            Console.WriteLine(car);
            Console.WriteLine(truck);
        }
    }
}
