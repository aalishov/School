namespace P06_Vehicles
{
    public class Program
    {
        public static void Main()
        {
            Vehicle v1 = CreateVehicle(Console.ReadLine());
            Vehicle v2 = CreateVehicle(Console.ReadLine());

            int n=int.Parse(Console.ReadLine());

            Vehicle current = null;

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                string cmd = input[0];
                string type = input[1];
                double amount = double.Parse(input[2]);

                current = type == nameof(Car) ? v1 : v2;

                string result = cmd == "Refuel" ? current.Refuel(amount) : current.Drive((int)amount);
                Console.WriteLine(result);
            }

            Console.WriteLine(v1);
            Console.WriteLine(v2);
        }

        public static Vehicle CreateVehicle(string input)
        {
            string[] info = input.Split(" ");
            string type = info[0];
            double fuelQuantity = double.Parse(info[1]);
            double fuelConsumptio = double.Parse(info[2]);

            switch (type)
            {
                case nameof(Car):
                    return new Car(fuelQuantity, fuelConsumptio);
                case nameof(Truck):
                    return new Truck(fuelQuantity, fuelConsumptio);
                default:
                    return null;
            }
        }
    }
}