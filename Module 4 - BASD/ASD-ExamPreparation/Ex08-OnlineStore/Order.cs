using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex08_OnlineStore
{
    public class Order
    {
        public int OrderNumber { get; set; }
        private List<Product> products;
        public static int OrdersCount;

        public Order(int orderNumber, List<Product> productsList)
        {
            this.OrderNumber = orderNumber;
            this.products = productsList;
            OrdersCount++;
        }
        public void AddProduct(Product product)
        {
            this.products.Add(product);
        }

        public double GetOrderTotalPrice()
        {
            return products.Sum(p=>p.Price);
        }

        public double GetDiscountedProductsTotalPrice()
        {
            return products.Where(p => p.IsOnPromotion = true).Sum(p => p.Price);
        }

        public double GetDiscountedProductsCount()
        {
            return products.Where(p => p.IsOnPromotion = true).Count();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Order #{this.OrderNumber} has the following products:");
            foreach (var product in this.products)
            {
                sb.AppendLine($"### Product -> {product.ToString()}");
            }

            return sb.ToString().TrimEnd();
        }

    }
}
