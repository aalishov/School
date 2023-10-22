using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSystem
{
    public class Receipt
    {
        private readonly List<Product> products;
        private string customerName;

        public Receipt(string customerName)
        {
            CustomerName = customerName;
            products = new List<Product>();
        }

        public string CustomerName
        {
            get { return customerName; }
            private set
            {
                if (value.Length < 2 || value.Length > 40)
                {
                    throw new ArgumentException("Customer Name should be between 2 and 40 characters!");
                }
                customerName = value;
            }
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Receipt of {CustomerName}");
            sb.AppendLine($"Total Price: {products.Sum(p => p.Price):f2}");
            sb.AppendLine($"Products:");

            products.ForEach(x=>sb.AppendLine(x.ToString()));

            return sb.ToString().TrimEnd();
        }
    }
}
