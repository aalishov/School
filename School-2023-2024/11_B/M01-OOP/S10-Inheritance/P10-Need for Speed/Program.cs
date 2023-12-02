using System.Text;

namespace P10_Need_for_Speed
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool isEqual = nameof(Motorcycle) == "Motorcycle";
            Console.WriteLine(isEqual);

            string type = Console.ReadLine();
            int hp = int.Parse(Console.ReadLine());
            double fuel = double.Parse(Console.ReadLine());
            double km = double.Parse(Console.ReadLine());
            Vehicle vehicle = null;

            switch (type)
            {
                case nameof(Motorcycle):
                    vehicle = new Motorcycle(fuel, hp);
                    break;
                case nameof(CrossMotorcycle):
                    vehicle = new CrossMotorcycle(fuel, hp);
                    break;
                case nameof(RaceMotorcycle):
                    vehicle = new RaceMotorcycle(fuel, hp);
                    break;
                case nameof(Car):
                    vehicle = new Car(fuel, hp);
                    break;
                case nameof(FamilyCar):
                    vehicle = new FamilyCar(fuel, hp);
                    break;
                case nameof(SportCar):
                    vehicle = new SportCar(fuel, hp);
                    break;
                default:
                    break;
            }
            vehicle.Drive(km);
            Console.WriteLine($"Left fuel {vehicle.Fuel:f2}");
        }
    }
}