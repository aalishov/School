namespace P01_StoreSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Store
    {
        private readonly List<Product> products;
        private string name;
        private string type;

        public Store(string name, string type)
        {
            this.Name = name;
            this.Type = type;
            this.products = new List<Product>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Store name must not be null or empty!");
                }

                this.name = value;
            }
        }

        public string Type
        {
            get
            {
                return this.type;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Store type must not be null or empty!");
                }

                this.type = value;
            }
        }

        public double Revenue { get; set; }

        public bool ReceiveProduct(Product product)
        {
            if (this.products.Any(x => x.Name == product.Name))
            {
                return false;
            }

            this.products.Add(product);
            return true;
        }

        public bool SellProduct(string name, int quantity)
        {
            Product product = this.products.FirstOrDefault(x => x.Name == name);

            if (product == null || product.Quantity < quantity)
            {
                return false;
            }

            if (product.Quantity - quantity == 0)
            {
                this.products.Remove(product);
            }
            else
            {
                product.Quantity -= quantity;
            }

            this.Revenue += quantity * product.FinalPrice;

            return true;
        }

        public Product GetProduct(string name)
        {
            return this.products.FirstOrDefault(x => x.Name == name);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"****Store: {this.Name} <{this.Type}>");
            sb.AppendLine($"****Available products: <{this.products.Count}>");

            foreach (var product in this.products)
            {
                sb.AppendLine($"******{product.Name} ({product.Quantity})");
            }

            sb.AppendLine($"****Revenue: <{this.Revenue:f2}BGN>");

            return sb.ToString().TrimEnd();
        }
    }
}
