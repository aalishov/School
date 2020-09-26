namespace StorageMaster.Entities.Storage
{
    using StorageMaster.Entities.Vehicles;
    using System.Collections.Generic;
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
