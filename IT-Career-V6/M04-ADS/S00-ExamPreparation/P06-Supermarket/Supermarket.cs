using System.Collections.Generic;
using System;
using System.Linq;

internal class Supermarket
{
    private List<Product> products;

    public Supermarket(string name)
    {
        Name = name;
        products = new List<Product>();
    }

    public string Name { get; set; }

    public IReadOnlyList<Product> Products
    {
        get
        {
            return products;
        }
    }

    public void AddProduct(string name, double price)
    {
        products.Add(new Product(name, price));
    }

    public double AveragePriceInRange(double start, double end)
    {
        return products
            .Where(x => x.Price >= start && x.Price <= end)
            .Average(x => x.Price);
    }

    public List<string> FilterProductsByPrice(double price)
    {
        return products
            .Where(x => x.Price < price)
            .Select(x => x.Name)
            .ToList();
    }

    public List<Product> SortAscendingByName()
    {
        products = products.OrderBy(x => x.Name).ToList();
        return products;
    }

    public List<Product> SortDescendingByPrice()
    {
        products = products.OrderByDescending(x => x.Price).ToList();
        return products;
    }

    public bool CheckProductIsInSupermarket(string name)
    {
        return products.Any(x => x.Name == name);
    }

    public string[] ProvideInformationAboutAllProducts()
    {
        return products.Select(x => x.ToString()).ToArray();
    }
}