using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class RepairShop
    {
    private List<Vehicle> vehicles = new List<Vehicle>();

    public RepairShop(int capacity)
    {
        Capacity = capacity;
    }

    public int Capacity { get; set; }
    public void AddVehicle(Vehicle vehicle)
    {
        if (vehicles.Count<Capacity)
        {
             vehicles.Add(vehicle);
        }
    }
    public bool RemoveVehicle(string vin)
    {
        Vehicle vehicle = vehicles.FirstOrDefault(vehicle=> vehicle.VIN == vin);
        return vehicles.Remove(vehicle);

    }
    public int GetCount() { return vehicles.Count; }
    public Vehicle GetLowestMileage()
    {
        Vehicle vehicle = vehicles.OrderBy(vehicle=> vehicle.Mileage).FirstOrDefault();
        return vehicle;
    }
    public string Report()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Vehicles in the preparatory:");
        foreach (var vehicle in vehicles)
        {
            sb.AppendLine(vehicle.ToString());
        }
        return sb.ToString();

    }
}

