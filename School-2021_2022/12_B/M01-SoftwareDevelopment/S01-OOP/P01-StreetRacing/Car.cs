namespace P01_StreetRacing
{
    using System.Text;
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
            sb.AppendLine($"Make: {this.Make}");
            sb.AppendLine($"Model: {this.Model}");
            sb.AppendLine($"License Plate: {this.LicensePlate}");
            sb.AppendLine($"Horse Power: {this.HorsePower}");
            sb.AppendLine($"Weight: {this.Weight}");
            return sb.ToString().TrimEnd();
        }
    }
}
