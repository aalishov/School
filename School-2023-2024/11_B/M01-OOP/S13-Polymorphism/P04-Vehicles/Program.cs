namespace P04_Vehicles
{
    public class Program
    {
        public static void Main()
        {
            Car c = new Car(20, 1, 60);
            Truck t = new Truck(100, 2, 150);

            Console.WriteLine(c.Refuel(100));
            Console.WriteLine(t.Refuel(100));
            Console.WriteLine(t.Refuel(50));
        }
    }
}