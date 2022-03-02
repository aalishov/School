namespace P02_DziCars
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class Program
    {
        private static List<Car> cars = new List<Car>();
        public static void Main()
        {
            string[] carsInfo = ReadFile();

            CreateCars(carsInfo);

            Output();
        }

        private static string[] ReadFile()
        {
            string filePath = "data.txt";
            string[] lines = File.ReadAllLines(filePath);
            return lines;
        }

        private static void CreateCars(string[] lines)
        {
            for (int i = 0; i < lines.Length; i += 3)
            {
                string carType = lines[i];
                string carBrand = lines[i + 1];
                string[] carInfo = lines[i + 2].Split(' ');
                int year = int.Parse(carInfo[0]);
                int mileage = int.Parse(carInfo[1]);
                double value = double.Parse(carInfo[2]);
                if (carType == "1")
                {
                    cars.Add(new Car(carBrand, year, mileage, value));
                }
                else if (carType == "2")
                {
                    int tonnage = int.Parse(carInfo[3]);
                    cars.Add(new Truck(carBrand, year, mileage, value, tonnage));
                }
            }
        }

        private static void Output()
        {
            for (int i = cars.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(cars[i]);
            }
        }
    }
}
