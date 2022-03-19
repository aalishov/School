using Product.Models;
using Product.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.DataProcessor
{
    public class DataSeeder
    {
        private ProductsService service = new ProductsService();

        public DataSeeder()
        {
            SeedProducts();
        }
        public void SeedProducts()
        {
            string imageUrl = "https://a.ubuy.com.kw/skin/frontend/default/ubuy/images/not-available.png";

            if (service.GetProducts().Any())
            {
                Console.WriteLine("Database is not empty!");
                return;
            }

            List<Category> categories = new List<Category>();
            for (int i = 0; i < 10; i++)
            {
                categories.Add(new Category() { Name = $"Category {i}" });
            }

            for (int i = 0; i < 1000; i++)
            {
                Random random = new Random();
                string name = $"Product {i}";
                string price = $"{random.Next(1, 20000) *   random.NextDouble()}";
                string stock = $"{random.Next(0, 1000)}";
                string category = categories[random.Next(0, categories.Count - 1)].Name;
                service.AddProduct(name, price, stock, category, imageUrl);
                Console.WriteLine($"Add product: {name}, price: {price}, category: {category}");
            }
        }
    }
}
