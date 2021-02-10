namespace P04_VehicleLibrary
{
    public class Car : Vehicle
    {
        const double SummerConsumption = 1.6;
        public Car(string brand, string model, double fuelConsumption, double fuel) : base(brand, model, fuelConsumption+SummerConsumption, fuel)
        {
        }
    }
}
