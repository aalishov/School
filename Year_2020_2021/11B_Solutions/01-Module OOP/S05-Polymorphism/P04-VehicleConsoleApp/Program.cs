using P04_VehicleLibrary;
using System;

namespace P04_VehicleConsoleApp
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter car info: ");
            string[] carInfo = Console.ReadLine().Split(' ');
            Console.WriteLine("Enter truck info");
            string[] truckInfo = Console.ReadLine().Split(' ');

            Vehicle car = new Car(carInfo[0], carInfo[1], double.Parse(carInfo[2]), double.Parse(carInfo[3]));
            Vehicle truck = new Truck(truckInfo[0], truckInfo[1], double.Parse(truckInfo[2]), double.Parse(truckInfo[3]));

            while (true)
            {
                Console.WriteLine("Enter commands!");
                string[] cmdArgs = Console.ReadLine().Split(' ');
                string cmd = cmdArgs[0].ToLower();

                if (cmd=="end")
                {
                    break;
                }

                string machine = cmdArgs[1].ToLower();
                double value = double.Parse(cmdArgs[2]);

                if (cmd=="drive")
                {
                    if (machine=="car")
                    {
                        Console.WriteLine(car.Drive(value));
                    }
                    else if (machine == "truck")
                    {
                        Console.WriteLine(truck.Drive(value));
                    }
                    else
                    {
                        Console.WriteLine("Invalid vehicle!");
                    }
                }
                else if (cmd=="refuel")
                {
                    if (machine == "car")
                    {
                        Console.WriteLine(car.Refuel(value));
                    }
                    else if (machine == "truck")
                    {
                        Console.WriteLine(truck.Refuel(value));
                    }
                    else
                    {
                        Console.WriteLine("Invalid vehicle!");
                    }
                }
                else
                {
                    Console.WriteLine("Not suported command!");
                }
            }
        }
    }
}
