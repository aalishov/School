public class Program
{
    private readonly static Dictionary<string, Engine> engines = new Dictionary<string, Engine>();
    private readonly static Dictionary<string, Car> cars = new Dictionary<string, Car>();
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);
        for (int i = 0; i < n; i++)
        {
            string[] engineInfo = Console.ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string model = engineInfo[0];
            int power = int.Parse(engineInfo[1]);
            int displacement = 0;
            string efficiency = "n/a";
            if (engineInfo.Length == 3)
            {
                if (int.TryParse(engineInfo[2], out displacement))
                {
                    displacement = int.Parse(engineInfo[2]);
                }
                else
                {
                    efficiency = engineInfo[2];
                }
            }
            else if (engineInfo.Length == 4)
            {
                displacement = int.Parse(engineInfo[2]);
                efficiency = engineInfo[3];
            }
            if (!engines.ContainsKey(model))
            {
                engines.Add(model, new Engine(model, power, displacement, efficiency));
            }
        }
        int m = int.Parse(Console.ReadLine()!);
        for (int i = 0; i < m; i++)
        {
            string[] carInfo = Console.ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string model = carInfo[0];
            string engineModel = carInfo[1];
            int weight = 0;
            string color = "n/a";
            if (carInfo.Length == 3)
            {
                if (int.TryParse(carInfo[2], out weight))
                {
                    weight = int.Parse(carInfo[2]);
                }
                else
                {
                    color = carInfo[2];
                }
            }
            else if (carInfo.Length == 4)
            {
                weight = int.Parse(carInfo[2]);
                color = carInfo[3];
            }
            if (!cars.ContainsKey(model))
            {
                cars.Add(model, new Car(model, engines[engineModel], weight, color));
            }
        }

        foreach (var car in cars.Values)
        {
            Console.WriteLine(car);
        }
    }
}

