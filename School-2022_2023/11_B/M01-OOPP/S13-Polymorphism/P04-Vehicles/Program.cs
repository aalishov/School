using System;
public class Program
{
    static void Main()
    {   
        string[] carInput = Console.ReadLine().Split(' ');
        string[] truckInput = Console.ReadLine().Split(' ');
        int numberOfCommands = int.Parse(Console.ReadLine());

        Car car = new Car() { FuelConsumpiton = double.Parse(carInput[2]), FuelQuantity = double.Parse(carInput[1]) };
        Truck truck = new Truck() { FuelConsumpiton = double.Parse(truckInput[2]), FuelQuantity = double.Parse(truckInput[1]) };

        for (int i = 0; i < numberOfCommands; i++)
        {
            string[] command = Console.ReadLine().Split(' ');
            if (command[0] == "Drive" && command[1] == "Car")
            {
                Console.WriteLine(car.Drive(int.Parse(command[2])));
            }
            else if (command[0] == "Drive" && command[1] == "Truck")
            {
                Console.WriteLine(truck.Drive(int.Parse(command[2])));
            }
            else if (command[0] == "Refuel" && command[1] == "Car")
            {
                car.Refuel(double.Parse(command[2]));
            }
            else
            {
                truck.Refuel(double.Parse(command[2]));
            }
            
        }
        Console.WriteLine(car);
        Console.WriteLine(truck);
    }
}

