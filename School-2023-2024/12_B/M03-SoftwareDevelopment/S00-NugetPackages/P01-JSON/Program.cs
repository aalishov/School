
using Newtonsoft.Json;

public class Program
{
    public static void Main()
    {
        Car car = new Car()
        {
            Brand = "BMW",
            Model = "X5",
            Color = Color.Black,
            Tyres = new Tyre[]
            {
                new Tyre() { Pressure = 2.8 },
                new Tyre() { Pressure = 2.8 },
                new Tyre() { Pressure = 3.2 },
                new Tyre() { Pressure = 3.2 }
            }
        };

        string result = JsonConvert.SerializeObject(car, Formatting.Indented);
        Console.WriteLine(result);

        Vehicle vehicle = JsonConvert.DeserializeObject<Vehicle>(result);
        Console.WriteLine(vehicle);
    }
}
