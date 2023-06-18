using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutomotiveRepairShop
{
    public class RepairShop
    {
        private readonly List<Vehicle> vehicles;
        public RepairShop(int capacity)
        {
            vehicles = new List<Vehicle>();
            Capacity = capacity;
        }

        public IReadOnlyList<Vehicle> Vehicles { get { return vehicles; } }

        public int Capacity { get; private set; }

        public void AddVehicle(Vehicle vehicle)
        {
            if (Vehicles.Count < Capacity)
            {
                vehicles.Add(vehicle);
            }
        }

        public bool RemoveVehicle(string vin)
        {
            Vehicle vehicle = Vehicles.FirstOrDefault(x => x.VIN == vin);
            return vehicles.Remove(vehicle);
        }

        public int GetCount()
        {
            return Vehicles.Count;
        }

        public Vehicle GetLowestMileage()
        {
            return Vehicles.OrderBy(x => x.Mileage).FirstOrDefault();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Vehicles in the preparatory:");
            vehicles.ForEach(x => sb.AppendLine(x.ToString()));

            return sb.ToString().TrimEnd();
        }
    }
}
