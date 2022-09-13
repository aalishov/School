namespace Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumtion) : base(fuelQuantity, fuelConsumtion)
        {
        }
        public override void Refuel(double quantity)
        {
            quantity *= 0.95;
            base.Refuel(quantity);
        }
        public override double FuelConsumption
        {
            get { return base.FuelConsumption + 1.6; }
        }
    }
}
