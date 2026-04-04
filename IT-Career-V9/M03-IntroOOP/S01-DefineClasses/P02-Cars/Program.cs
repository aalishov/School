using Garage;

public class Program
{
    private static Dictionary<string, Car> cars = new Dictionary<string, Car>();

    public static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);


        for (int i = 0; i < n; i++)
        {
            string[] carInfo = Console.ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string model = carInfo[0];
            double fuel = double.Parse(carInfo[1]);
            double consumption = double.Parse(carInfo[2]);

            if (!cars.ContainsKey(model))
            {
                cars.Add(model, new Car(model, fuel, consumption));
            }
        }

        while (true)
        {
            string[] line = Console.ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            if (line[0] == "End") { break; }

            string model = line[1];
            double distance = double.Parse(line[2]);

            Console.WriteLine(cars[model].Drive(distance));
        }

        foreach (var car in cars.Values)
        {
            Console.WriteLine(car);
        }
    }
}

