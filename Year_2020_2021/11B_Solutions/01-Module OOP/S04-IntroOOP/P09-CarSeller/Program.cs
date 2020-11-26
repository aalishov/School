using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    //Полета
    private static List<Engine> engines = new List<Engine>();
    private static List<Car> cars = new List<Car>();

    public static void Main()
    {
        CreateEngines();

        CreateCars();

        PrintOutput();
    }

    private static void PrintOutput()
    {
        Console.WriteLine(string.Join($"{Environment.NewLine}", cars));
    }

    private static void CreateCars()
    {
        int m = int.Parse(Console.ReadLine());

        for (int i = 0; i < m; i++)
        {
            string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            string model = line[0];
            string engineModel = line[1];
            Engine engine = engines.FirstOrDefault(x => x.Model == engineModel);

            Car car = new Car(model, engine);

            if (line.Length == 3)
            {
                if (int.TryParse(line[2], out _))
                {
                    int weight = int.Parse(line[2]);
                    car.Weight = weight;
                }
                else
                {
                    string color = line[2];
                    car.Color = color;
                }
            }
            else if (line.Length == 4)
            {
                int weight = int.Parse(line[2]);
                car.Weight = weight;
                string color = line[3];
                car.Color = color;
            }
            cars.Add(car);
        }
    }

    private static void CreateEngines()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            string engineModel = line[0];
            int horsePower = int.Parse(line[1]);

            Engine engine = new Engine(engineModel, horsePower);

            if (line.Length == 3)
            {
                if (int.TryParse(line[2], out _))
                {
                    engine.Displacement = int.Parse(line[2]);
                }
                else
                {
                    engine.Efficiency = line[2];
                }
            }
            else if (line.Length == 4)
            {
                engine.Displacement = int.Parse(line[2]);
                engine.Efficiency = line[3];
            }
            engines.Add(engine);
        }
    }
}

