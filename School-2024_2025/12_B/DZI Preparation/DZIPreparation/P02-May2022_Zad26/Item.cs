public class Item : IComparable<Item>
{
    private double price;
    private string description;

    public Item(string description, double price)
    {
        Description = description;
        Price = price;
    }

    public string Description
    {
        get { return description; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Invalid description!");
            }
            description = value;
        }
    }

    public double Price
    {
        get { return price; }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Invalid price!");
            }
            price = value;
        }
    }

    public int CompareTo(Item? other)
    {
        if (this.Description.CompareTo(other.Description) != 0)
        {
            return this.Description.CompareTo(other.Description);
        }
        return this.Price.CompareTo(other.Price);
    }

    public override string ToString()
    {
        return $"{Description} ({Price:f2})";
    }
}

