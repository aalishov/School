namespace StorageMaster.Entities.Storage
{
    using StorageMaster.Entities.Products;
    using StorageMaster.Entities.Vehicles;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class Storage
    {
        private List<Vehicle> vehicles;
        private List<Product> products;

        protected Storage(string name, int capacity, int garageSlots, IEnumerable<Vehicle> vehicles)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.GarageSlots = garageSlots;
            this.vehicles = vehicles.ToList();
        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int GarageSlots { get; set; }

        public bool IsFull
        {
            get
            {
                if (this.Products.Sum(x => x.Weight) >= Capacity)
                {
                    return true;
                }
                return false;
            }
        }

        public IReadOnlyCollection<Vehicle> Garage
        {
            get => vehicles.AsReadOnly();
        }
        public IReadOnlyCollection<Product> Products
        {
            get => products.AsReadOnly();
        }

        public Vehicle GetVehicle(int garageSlot)
        {
            if (garageSlot < 0 || garageSlot >= Capacity)
            {
                throw new InvalidOperationException("Invalid garage slot!");
            }

            if (vehicles[garageSlot] == null)
            {
                throw new InvalidOperationException("No vehicle in this garage slot!");
            }

            return vehicles[garageSlot];
        }

        public int SendVehicleTo(int garageSlot, Storage deliveryLocation)
        {
            Vehicle vehicle = this.GetVehicle(garageSlot);
            int freeSlot = deliveryLocation.FreeGarageSlot();
            vehicles[garageSlot] = null;
            deliveryLocation.vehicles[freeSlot] = vehicle;
            return freeSlot;
        }

        public int UnloadVehicle(int garageSlot)
        {
            if (this.IsFull)
            {
                throw new InvalidOperationException("Storage is full!");
            }
            Vehicle vehicle = GetVehicle(garageSlot);

            int unloadProducts = 0;

            for (int i = 0; i < vehicle.Trunk.Count; i++)
            {
                if (IsFull)
                {
                    break;
                }
                products.Add(vehicle.Unload());
                unloadProducts++;
            }
            return unloadProducts;
        }

        private int FreeGarageSlot()
        {
            for (int i = 0; i < this.vehicles.Count; i++)
            {
                if (vehicles[i] == null)
                {
                    return i;
                }
            }
            throw new InvalidOperationException("No room in garage!");
        }
    }
}
