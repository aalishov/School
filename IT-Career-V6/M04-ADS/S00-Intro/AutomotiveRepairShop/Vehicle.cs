using static System.Net.Mime.MediaTypeNames;

namespace AutomotiveRepairShop
{
    public class Vehicle
    {
        public Vehicle(string vin, int mileage, string damage)
        {
            VIN = vin;
            Mileage = mileage;
            Damage = damage;
        }

        public string VIN { get; private set; }

        public int Mileage { get; private set; }

        public string Damage { get; private set; }

        public override string ToString()
        {
            return $"Damage: {Damage}, Vehicle: {VIN} ({Mileage} km)";
        }
    }
}
