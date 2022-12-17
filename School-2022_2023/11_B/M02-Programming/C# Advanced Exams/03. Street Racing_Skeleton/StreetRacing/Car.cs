using System.Text;

namespace StreetRacing
{
    public class Car
    {
        public Car(string make, string model, string licensePlate, int horsePower, double weight)
        {
            this.Make = make;
            this.Model = model;
            this.LicensePlate = licensePlate;
            this.HorsePower = horsePower;
            this.Weight = weight;
        }

        public string Make { get; private set; }
        public string Model { get; private set; }
        public string LicensePlate { get; private set; }
        public int HorsePower { get; private set; }
        public double Weight { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Make: {Make}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"License Plate: {LicensePlate}");
            sb.AppendLine($"Horse Power: {HorsePower}");
            sb.AppendLine($"Weight: {Weight}");
            return sb.ToString().TrimEnd();
        }
    }
}
