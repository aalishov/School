namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main()
        {
            Car c = new Car() { Make = "Mercedes", Model = "C", Year = 2022, FuelConsumption = 1, FuelQuantity = 10 };
            Console.WriteLine(c.Drive(8)); 
            Console.WriteLine(c.Drive(10)); 
            Console.WriteLine(c.WhoAmI() ); 
        }
    }
}