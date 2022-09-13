using System;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumtion, double tankCapacity) : base(fuelQuantity, fuelConsumtion, tankCapacity)
        {
        }

        public override void Refuel(double quantity)
        {
            double originalQuantity = quantity;
            quantity *= 0.95;
            try
            {
                base.Refuel(quantity);
            }
            catch (ArgumentException ex)
            {
                throw new ArgumentException($"Cannot fit {originalQuantity} fuel in the tank");
            }
            
        }
        public override double FuelConsumption
        {
            get { return base.FuelConsumption + 1.6; }
        }
    }
}
