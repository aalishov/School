using System;
using System.Collections.Generic;

namespace Ex08_OnlineStore
{
    class Program
    {
        static Dictionary<string,Product> products = new Dictionary<string, Product>();
        static Dictionary<int, Order> orders = new Dictionary<int, Order>();
        static void Main(string[] args)
        {

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "End")
                {
                    break;
                }

                string[] cmdArgs = line.Split(' ');
                string cmd = cmdArgs[0];

                switch (cmd)
                {
                    case "CreateProduct":
                        CreateProduct(cmdArgs);
                        break;
                    case "CreateOrder":
                        CreateOrder(cmdArgs);
                        break;
                    case "AddToOrder":
                        AddToОrder(cmdArgs);
                         break;
                    case "GetOrderTotalPrice ":
                        GetOrderTotalPrice(cmdArgs);
                        break;
                    case "GetOrderDiscountedProductsPrice":
                        GetOrderDiscountedProductsPrice(cmdArgs);
                        break;
                    case "GetOrderDiscountedProductsCount":
                        break;
                    case "PrintProductInfoByName":
                        break;
                    case "PrintOrderByNumber":
                        break;
                    case "GetTotalOrdersCount":
                        Console.WriteLine($"Orders count: {Order.OrdersCount}");
                        break;
                    default:
                        break;
                }
            }

        }

        private static void GetOrderDiscountedProductsPrice(string[] cmdArgs)
        {
            int orderNumber = int.Parse(cmdArgs[1]);
            if (orders.ContainsKey(orderNumber))
            {
                double price = orders[orderNumber].GetDiscountedProductsTotalPrice();
                Console.WriteLine($"Order {orderNumber} discounted products price: {price:f2}");
            }
            else
            {
                Console.WriteLine("Order not found!");
            }
        }

        private static void GetOrderTotalPrice(string[] cmdArgs)
        {
            int orderNumber = int.Parse(cmdArgs[1]);
            if (orders.ContainsKey(orderNumber))
            {
               double price= orders[orderNumber].GetOrderTotalPrice();
                Console.WriteLine($"Order {orderNumber} total price: {price:f2}");
            }
            else
            {
                Console.WriteLine("Order not found!");
            }
        }

        private static void AddToОrder(string[] cmdArgs)
        {
            int orderNumber = int.Parse(cmdArgs[1]);
            if (orders.ContainsKey(orderNumber))
            {
                for (int i = 2; i < cmdArgs.Length; i++)
                {
                    string productName = cmdArgs[i];
                    if (products.ContainsKey(productName))
                    {
                        orders[orderNumber].AddProduct(products[productName]);
                        Console.WriteLine($"Product {productName} is added to order {orderNumber}");
                    }
                    else
                    {
                        Console.WriteLine($"Product {productName} isn't added to order {orderNumber}");
                    }
                }
            }

        }

        private static void CreateOrder(string[] cmdArgs)
        {
            int orderNumber = int.Parse(cmdArgs[1]);
            Order order = new Order(orderNumber, new List<Product>());
            for (int i =2; i < cmdArgs.Length; i++)
            {
                string productName = cmdArgs[i];
                if (products.ContainsKey(productName))
                {
                    order.AddProduct(products[productName]);
                }
            }
            if (!orders.ContainsKey(orderNumber))
            {
                orders.Add(orderNumber, order);
                Console.WriteLine("Order is created!");
            }
            else
            {
                Console.WriteLine("Order already exist");
            }
                        
        }

        private static void CreateProduct(string[] cmdArgs)
        {
            string name = cmdArgs[1];
            double price = double.Parse(cmdArgs[2]);
            Product product = new Product(name, price);
            if (cmdArgs.Length==4)
            {
                if (cmdArgs[3]=="true")
                {
                    product.IsOnPromotion = true;
                }
            }

            if (!products.ContainsKey(name))
            {
                products.Add(name, product);
                Console.WriteLine("Product is created!");
            }
            else
            {
                Console.WriteLine("Product already exist!");
            }
        }
    }
}
