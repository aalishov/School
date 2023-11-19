using P00_DemoClass_v1;

public class Customer
{
    private List<Product> products = new List<Product>();

    private string name;

    public Customer(string name)
    {
        Name = name;
    }
    public Customer(string name, string address) : this(name)
    {
        Address = address;
    }
    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Invalid name");
            }
            name = value;
        }
    }
    public string Address { get; set; }

    public void BuyProduct(Product product)
    {
        products.Add(product);
    }

    public void PrintMyProduct()
    {
        foreach (Product product in products)
        {
            Console.WriteLine(product);
        }
    }

}

