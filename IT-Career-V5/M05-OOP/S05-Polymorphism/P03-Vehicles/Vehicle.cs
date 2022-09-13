namespace Vehicles
{
    public class Vehicle
    {
        private double fuelConsumtion;

        public Vehicle(double fuelQuantity, double fuelConsumtion)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumtion;
        }
        public double FuelQuantity { get; private set; }
        public virtual double FuelConsumption
        {
            get => fuelConsumtion;
            private set => fuelConsumtion = value;
        }

        public string Drive(double distance)
        {
            double neededFuel = distance * this.FuelConsumption;
            if (neededFuel > this.FuelQuantity)
            {
                return $"{this.GetType().Name} needs refueling";
            }
            FuelQuantity -= neededFuel;
            return $"{this.GetType().Name} travelled {distance} km";
        }
        public virtual void Refuel(double quantity)
        {
            this.FuelQuantity += quantity;
        }
        public override string ToString()
        {
            return $"{GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
