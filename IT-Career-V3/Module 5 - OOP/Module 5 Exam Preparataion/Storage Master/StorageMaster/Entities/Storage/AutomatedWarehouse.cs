namespace StorageMaster.Entities.Storage
{
    using Entities.Vehicles;
    using System.Collections.Generic;

    public class AutomatedWarehouse : Storage
    {
        private const int capacity = 1;
        private const int garageSlots = 2;
        private static IEnumerable<Vehicle> vehicles = new List<Vehicle>() 
        { new Truck() };
        public AutomatedWarehouse(string name) : base(name, capacity, garageSlots, vehicles)
        {
        }
    }
}
