public class Product
{
    public Product(string name, double rating)
    {
        Name = name ;
        Price = rating;
    }

    public string Name { get; private set; }

    public double Price { get; private set; }

    public override string ToString()
    {
        return $"Product {Name} costs {Price:f1} lv.";
    }
}
