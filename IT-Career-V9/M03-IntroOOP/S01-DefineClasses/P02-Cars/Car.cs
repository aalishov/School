namespace Garage
{
    public class Car
    {
        public Car(string model, double fuel, double consumption)
        {
            this.Model = model;
            this.Fuel = fuel;
            this.Consumption = consumption;
        }

        public string Model { get; private set; }

        public double Fuel { get; private set; }

        public double Consumption { get; private set; }

        public double Distance { get; private set; }

        public string Drive(double distance)
        {
            double neededFuel = distance * this.Consumption;
            if (neededFuel > this.Fuel)
            {
                return "Insufficient fuel for the drive";
            }
            this.Fuel -= neededFuel;
            this.Distance += distance;
            return $"Traveled distance: {distance}, fuel consumed: {neededFuel:f2}, fuel: {this.Fuel:f2}";
        }

        public override string ToString()
        {
            return $"{this.Model} {this.Fuel:f2} {this.Distance}";
        }
    }


}