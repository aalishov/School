namespace StorageMaster
{
    using Entities.Products;
    using Entities.Storage;
    using Entities.Vehicles;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    // &&
    // ||
    // !   !(true)  !(5>2 || 6>8)
    public class StorageMaster
    {
        private readonly Dictionary<string, Stack<Product>> products;
        private readonly Dictionary<string, Storage> storages;
        private Vehicle currentVehicle;

        public StorageMaster()
        {
            products = new Dictionary<string, Stack<Product>>();
            storages = new Dictionary<string, Storage>();
            currentVehicle = null;
        }

        public string AddProduct(string type, double price)
        {
            if (!products.ContainsKey(type))
            {
                products.Add(type, new Stack<Product>());
            }

            switch (type)
            {
                case "HardDrive":
                    products[type].Push(new HardDrive(price));
                    break;
                case "SolidStateDrive":
                    products[type].Push(new SolidStateDrive(price));
                    break;
                case "Gpu":
                    products[type].Push(new Gpu(price));
                    break;
                case "Ram":
                    products[type].Push(new Ram(price));
                    break;
                default:
                    throw new InvalidOperationException("Invalid product type!");
            }
            return $"Added {type} to pool";
        }
        public string RegisterStorage(string type, string name)
        {
            if (!storages.ContainsKey(name))
            {
                switch (type)
                {
                    case "AutomatedWarehouse":
                        storages.Add(name, new AutomatedWarehouse(name));
                        break;
                    case "DistributionCenter":
                        storages.Add(name, new DistributionCenter(name));
                        break;
                    case "Warehouse":
                        storages.Add(name, new Warehouse(name));
                        break;
                    default: throw new InvalidOperationException("Invalid storage type!");
                }
            }
            return $"Registered {name}";
        }
        public string SelectVehicle(string storageName, int garageSlot)
        {
            currentVehicle = storages[storageName].GetVehicle(garageSlot);
            return $"Selected {currentVehicle.GetType().Name}";
        }
        public string LoadVehicle(IEnumerable<string> productNames)
        {
            int counter = 0;
            foreach (var productName in productNames)
            {
                if (products[productName].Any())
                {
                    Product product = products[productName].Pop();
                    currentVehicle.LoadProduct(product);
                    counter++;
                }
                else
                {
                    throw new InvalidOperationException($"{productName} is out of stock!");
                }
            }
            return $"Loaded {counter}/{productNames.Count()} products into {currentVehicle.GetType().Name}";
        }
        public string SendVehicleTo(string sourceName, int sourceGarageSlot, string destinationName)
        {
            if (!storages.ContainsKey(sourceName))
            {
                throw new InvalidOperationException("Invalid source storage!");
            }
            if (!storages.ContainsKey(destinationName))
            {
                throw new InvalidOperationException("Invalid destination storage!");
            }

            Vehicle vehicle = storages[sourceName].GetVehicle(sourceGarageSlot);
            int destinationGarageSlot = storages[sourceName]
                .SendVehicleTo(sourceGarageSlot, storages[destinationName]);

            return $"Sent {vehicle.GetType().Name} to {destinationName} (slot {destinationGarageSlot})";
        }
        public string UnloadVehicle(string storageName, int garageSlot)
        {
            Vehicle vehicle = storages[storageName].GetVehicle(garageSlot);
            int productsInVehicle = vehicle.Trunk.Count();
            int unloadCout = storages[storageName].UnloadVehicle(garageSlot);
            return $"Unloaded {unloadCout}/{productsInVehicle} products at {storageName}";
        }

        public string GetStorageStatus(string storageName)
        {
            StringBuilder sb = new StringBuilder();
            double productsWeight = storages[storageName].Products.Sum(x => x.Weight);

            double storagesCapacity = storages[storageName].Capacity;

            StringBuilder productsInfo = new StringBuilder();
            foreach (var s in storages)
            {
                foreach (var p in s.Value.Products.OrderBy(x=>x.GetType().Name))
                {
                    productsInfo.Append(p.GetType().Name);
                }
            }

            sb.AppendLine($"Stock ({productsWeight}/{storagesCapacity}): [{productsInfo}]");

            StringBuilder garageInfo = new StringBuilder();
            foreach (var g in storages[storageName].Garage)
            {

                //if (g!=null)
                //{
                //    garageInfo.Append(g.GetType().Name);
                //}
                //else
                //{
                //    garageInfo.Append("empty");
                //}
                garageInfo.Append(g != null ? g.GetType().Name+"|" : "empty"+"|");
            }
            garageInfo.Remove(garageInfo.Length - 1, 1);
            sb.AppendLine($"Garage: [{garageInfo}]");

            return sb.ToString().TrimEnd();
        }

        public string GetSummary()
        {
           
            StringBuilder sb = new StringBuilder();

            foreach (var storage in storages.OrderByDescending(x=>x.Value.Products.Sum(p=>p.Price)))
            {
                sb.AppendLine($"{storage.Key}:");
                sb.AppendLine($"Storage worth: ${storage.Value.Products.Sum(p => p.Price):F2}");
            }
            return sb.ToString();
        }
    }
}
