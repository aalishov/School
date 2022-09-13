namespace Vehicles
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumtion, double tankCapacity) : base(fuelQuantity, fuelConsumtion, tankCapacity)
        {
        }

        public override double FuelConsumption
        {
            get { return base.FuelConsumption + 0.9; }
        }
    }
}
