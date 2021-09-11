using System;
using System.Collections.Generic;

namespace P04_NeedForSpeed
{
    class Program
    {
        static void Main(string[] args)
        {
            RaceMotorcycle raceMotorcycle = new RaceMotorcycle(50, 100);
            CrossMotorcycle crossMotorcycle = new CrossMotorcycle(50, 100);
            FamilyCar familyCar = new FamilyCar(50, 100);
            SportCar sportCar = new SportCar(50, 100);

            List<Vehicle> vehicles = new List<Vehicle>() { raceMotorcycle, crossMotorcycle, familyCar, sportCar };

            foreach (var v in vehicles)
            {
                Console.WriteLine(v.Drive(10));
                Console.WriteLine(v.Drive(250));
                Console.WriteLine(v.Drive(80));
                Console.WriteLine(v.Drive(110));
            }
            Console.WriteLine(new string('*',40));
        }
    }
}
