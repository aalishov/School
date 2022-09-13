namespace Vehicles
{
    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double fuelConsumtion, double tankCapacity) : base(fuelQuantity, fuelConsumtion, tankCapacity)
        {
        }
        public bool HasPassangers { get; set; }
        public override double FuelConsumption
        {
            get
            {
                if (HasPassangers)
                {
                    return base.FuelConsumption + 1.4;
                }
                return base.FuelConsumption;
            }
        }
    }
}
