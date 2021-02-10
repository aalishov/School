using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<Car> garage = new List<Car>(); //Списък в който запазваме колите


        //Въвеждаме брой автомобили
        Console.Write("Car count: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter car info: ");
            string[] info = Console.ReadLine()
                .Split(' ')
                .ToArray();

            string model = info[0];
            double fuel = double.Parse(info[1]);
            double consumption = double.Parse(info[2]);

            Car car = new Car(model, fuel, consumption);
            garage.Add(car);
        }


        while (true)
        {
            Console.Write("Command: ");
            string[] line = Console.ReadLine()
                .Split(' ')
                .ToArray();

            string cmd = line[0];
            if (cmd == "end")
            {
                break;
            }

            string model = line[1];


            Car driveThitCar = garage.FirstOrDefault(c => c.Model == model);

            switch (cmd)
            {
                case "Drive":
                    double km = double.Parse(line[2]);
                    if (driveThitCar == null)
                    {
                        Console.WriteLine("Car not found!");
                    }
                    else
                    {
                        Console.WriteLine(driveThitCar.Drive(km));
                    }
                    break;
                case "Refuel":
                    double liters = double.Parse(line[2]);
                    Console.WriteLine(driveThitCar.Refuel(liters));
                    break;

                default:
                    break;
            }


        }

        for (int i = 0; i < garage.Count; i++)
        {
            Console.WriteLine(garage[i]);
        }

    }
}

