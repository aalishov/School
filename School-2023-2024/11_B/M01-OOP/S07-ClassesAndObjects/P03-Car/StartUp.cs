namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
           Car c = new Car();
            Car c2 = new Car("Toyota", "Hybrid", 2023);
            Car c3 = new Car("Toyota", "Hybrid", 2023, 50, 2);

        }
    }
}