namespace NeedForSpeed
{
    public class Vehicle
    {
        public Vehicle(double fuel, int horsePower)
        {
            this.Fuel = fuel;
            this.HorsePower = horsePower;
        }
        public double DefaultFuelConsumption { get; set; } = 1.25;
        public virtual double FuelConsumption { get; set; } = 1.25;
        public double Fuel { get; set; }
        public int HorsePower { get; set; }
        public virtual void Drive(double kilometres)
        {
            this.Fuel -= kilometres * FuelConsumption;
            System.Console.WriteLine(this.Fuel);
        }
    }

}