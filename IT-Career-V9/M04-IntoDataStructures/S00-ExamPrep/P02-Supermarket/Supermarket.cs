using System.Collections.ObjectModel;

public class Supermarket
{
    private readonly List<Product> products;

    public Supermarket(string name)
    {
        Name = name;
        products = new List<Product>();
    }

    public string Name { get; private set; }

    public ReadOnlyCollection<Product> Products => products.AsReadOnly();

    public void AddProduct(string name, double price)
    {
        products.Add(new Product(name, price));
    }

    public double AveragePriceInRange(double start, double end)
    {
        if (products.Count == 0) { return 0; }
        return products.Where(b => b.Price >= start && b.Price <= end).Average(b => b.Price);
    }
    
    public bool CheckProductIsInSupermarket(string name)
    {
        return products.Any(x => x.Name == name);
    }

    public List<string> FilterProductsByPrice(double price)
    {
        return products
            .Where(b => b.Price < price)
            .Select(b => b.Name)
            .ToList();
    }

    public string[] ProvideInformationAboutAllProducts()
    {
        string[] result = new string[products.Count];

        for (int i = 0; i < products.Count; i++)
        {
            result[i] = products[i].ToString();
        }

        return result;
    }

    public List<Product> SortAscendingByName()
    {
        List<Product> sorted = products.OrderBy(x => x.Name).ToList();
        products.Clear();
        products.AddRange(sorted);
        return sorted;
    }

    public List<Product> SortDescendingByPrice()
    {
        List<Product> sorted = products.OrderByDescending(x => x.Price).ToList();
        products.Clear();
        products.AddRange(sorted);
        return sorted;
    }
}

