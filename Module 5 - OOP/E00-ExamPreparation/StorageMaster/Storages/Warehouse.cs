using StorageMaster.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Storages
{
    public class Warehouse : Storage
    {
        private const int capacity = 10;
        private const int garageSlots = 10;
        private static IEnumerable<Vehicle> vehicles = new List<Vehicle>()
            {
                new Semi(),
                new Semi(),
                new Semi()
            };
        public Warehouse(string name) : base(name, capacity, garageSlots, vehicles)
        {
        }
    }
}
