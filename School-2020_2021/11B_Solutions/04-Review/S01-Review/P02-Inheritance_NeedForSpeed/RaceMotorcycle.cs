public class RaceMotorcycle : Motorcycle
{
    public RaceMotorcycle(string brand, string model, int horsePower, double fuel) : base(brand, model, horsePower, fuel)
    {
    }

    public override double FuelConsumption => 8;
}

