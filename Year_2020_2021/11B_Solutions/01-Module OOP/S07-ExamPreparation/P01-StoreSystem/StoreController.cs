namespace P01_StoreSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class StoreController
    {
        private List<Store> stores;

        public StoreController()
        {
            this.stores = new List<Store>();
        }

        public string CreateStore(List<string> args)
        {
            string name = args[0];
            string type = args[1];

            if (!this.stores.Any(x => x.Name == name))
            {
                Store store = new Store(name, type);
                this.stores.Add(store);
                return $"Store {name} was successfully registerd in the system!";
            }
            else
            {
                return $"Store {name} is already registered!";
            }
        }

        public string ReceiveProduct(List<string> args)
        {
            string type = args[0];
            string name = args[1];
            int quantity = int.Parse(args[2]);
            double price = double.Parse(args[3]);
            double percentageMarkup = double.Parse(args[4]);
            string storeName = args[5];

            Product product = null;

            if (type == "Food")
            {
                product = new Food(name, quantity, price, percentageMarkup);
            }
            else if (type == "Drink")
            {
                product = new Drink(name, quantity, price, percentageMarkup);
            }
            else
            {
                return $"Product {type} is invalid!";
            }

            Store store = this.stores.FirstOrDefault(x => x.Name == storeName);

            if (store != null)
            {
                bool isReceived = store.ReceiveProduct(product);

                if (isReceived)
                {
                    return $"Product {name} was successfully delivered to {storeName}!";
                }
                else
                {
                    return $"Product {name} was already delivered to {storeName}!";
                }
            }
            else
            {
                return $"Invalid Store: {storeName}. Cannot find it in system!";
            }
        }

        public string SellProduct(List<string> args)
        {
            string name = args[0];
            int quantity = int.Parse(args[1]);
            string storeName = args[2];

            Store store = this.stores.FirstOrDefault(x => x.Name == storeName);

            if (store != null)
            {
                bool isSell = store.SellProduct(name, quantity);
                if (isSell)
                {
                    return $"Product {name} was successfully bought from {storeName}!";
                }
                else
                {
                    return $"Product {name} was already sold out!";
                }
            }
            else
            {
                return $"Invalid Store: {storeName}. Cannot find it in system!";
            }
        }

        public string StoreInfo(List<string> args)
        {
            string storeName = args[0];

            Store store = this.stores.FirstOrDefault(x => x.Name == storeName);

            if (store != null)
            {
                return store.ToString();
            }
            else
            {
                return $"Invalid Store: {storeName}. Cannot find it in system!";
            }
        }

        public string Shutdown()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Stores: {this.stores.Count}");

            foreach (var store in this.stores.OrderByDescending(x => x.Revenue).ThenBy(x => x.Name))
            {
                sb.AppendLine(store.ToString());
            }

            sb.AppendLine($"Stores: {this.stores.Sum(x => x.Revenue):f2}");

            return sb.ToString().TrimEnd();
        }
    }
}
