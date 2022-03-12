

namespace Product.Data
{
    using Product.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class DataSeeder
    {
        public DataSeeder()
        {
            Run();
        }

        public void Run()
        {
            AppDbContext context = new AppDbContext();


            Category food = new Category() { Name = "Food" };
            Category drink = new Category() { Name = "Drink" };
            Category book = new Category() { Name = "Book" };
            Category game = new Category() { Name = "Game" };
            Category car = new Category() { Name = "Car" };

            List<Product> products = new List<Product>()
            { new Product(){Name="BMW",Price=50000,Stock=4,Category=car,ImageUrl="https://th.bing.com/th/id/OIP.veJBDptvCncT8hiu21xPMwHaE8?w=247&h=180&c=7&r=0&o=5&dpr=1.25&pid=1.7" },
            new Product(){Name="Coca Cola",Price=5,Stock=4,Category=drink},
            new Product(){Name="Burger",Price=10,Stock=4,Category=food},
            new Product(){Name="C#",Price=50,Stock=4,Category=book},
            new Product(){Name="CS",Price=50,Stock=4,Category=game},
            };
            context.Products.AddRange(products);
            context.SaveChanges();
        }
    }
}
