namespace Vehicles
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumtion) : base(fuelQuantity, fuelConsumtion)
        {
        }
        public override double FuelConsumption
        {
            get { return base.FuelConsumption + 0.9; }
        }
    }
}
