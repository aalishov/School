
public class Furniture
{
    public Furniture(string name, decimal price, int quantity)
    {
        this.Name = name;
        this.Price = price;
        this.Quantity = quantity;
    }

    public string Name { get; set; }

    public decimal Price { get; set; }

    public int Quantity { get; set; }

    public decimal TotalPrice()
    {
        return this.Price * this.Quantity;
    }

    public override string ToString()
    {
        return $"Name: {this.Name}";
    }
}
