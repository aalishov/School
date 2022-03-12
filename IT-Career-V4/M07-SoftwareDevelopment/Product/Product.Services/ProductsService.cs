namespace Product.Services
{
    using Data;
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class ProductsService
    {
        private AppDbContext context = new AppDbContext();

        public ICollection<Product> GetProducts(int page = 1, int itemsPerPage = 10)
        {
            return context.Products
                .Skip((page - 1) * itemsPerPage)
                .Take(itemsPerPage)
                .ToList();
        }
        public int ProductsCount()
        {
            return this.context.Products.Count();   
        }
        public Product GetProduct(int id)
        {
            return context.Products.Find(id);
        }
        public void AddProduct(string name, string price, string stock, string categoryName, string imageUrl = null)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Invalid product name!");
            }
            if (double.TryParse(price, out _))
            {
                throw new ArgumentException("Invalid product price!");
            }
            if (int.TryParse(stock, out _))
            {
                throw new ArgumentException("Invalid product stock!");
            }
            if (string.IsNullOrWhiteSpace(categoryName))
            {
                throw new ArgumentException("Invalid product category!");
            }
            Category category = context.Categories.FirstOrDefault(x => x.Name == categoryName);
            if (category == null)
            {
                category = new Category() { Name = categoryName };
            }
            Product product = new Product()
            {
                Name = name,
                Price = double.Parse(price),
                Stock = int.Parse(stock),
                Category = category,
                ImageUrl = imageUrl
            };
            context.Products.Add(product);
            context.SaveChanges();
        }
        public void UpdateProductPrice(int productId, string price)
        {
            Product product = GetProduct(productId);
            if (product == null)
            {
                throw new ArgumentException("Invalid product id");
            }
            if (double.TryParse(price, out _))
            {
                throw new ArgumentException("Invalid product price");
            }
            product.Price=double.Parse(price);
            context.Products.Update(product);
            context.SaveChanges();
        }
        public void UpdateProductImageUrl(int productId, string url)
        {
            Product product = GetProduct(productId);
            if (product == null)
            {
                throw new ArgumentException("Invalid product id");
            }
            product.ImageUrl = url;
            context.Products.Update(product);
            context.SaveChanges();
        }
        public void DeleteProduct(int productId)
        {
            var product = GetProduct(productId);
            if (product==null)
            {
                throw new ArgumentException("Invalid product id");
            }
            context.Products.Remove(product);
            context.SaveChanges();
        }
    }
}
