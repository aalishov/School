using StorageMaster.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Storages
{
    public class DistributionCenter : Storage
    {
        private const int capacity = 2;
        private const int garageSlots = 5;
        private static IEnumerable<Vehicle> vehicles = new List<Vehicle>()
            {
                new Van(),
                new Van(),
                new Van()
            };
        public DistributionCenter(string name) : base(name, capacity, garageSlots, vehicles)
        {
        }
    }
}
