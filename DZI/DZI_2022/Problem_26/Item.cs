public class Item : IComparable<Item>
{
    private double price;
    private string description;

    public Item(string description, double price)
    {
        this.Description = description;
        this.Price = price;
    }

    public string Description
    {
        get { return description; }
        private set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Description cannot be null or empty");
            }
            description = value;
        }
    }
    public double Price
    {
        get { return price; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Price must be positive");
            }
            price = value;
        }
    }

    public int CompareTo(Item? other)
    {
        if (this.Description.CompareTo(other.Description) < 0)
        {
            return -1;
        }
        else if (this.Description.CompareTo(other.Description) > 0)
        {
            return 1;
        }
        else if (this.Price < other.Price)
        {
            return -1;
        }
        else if (this.Price > other.Price)
        {
            return 1;
        }
        return 0;
    }
    public override string ToString()
    {
        return $"{this.Description}({this.Price:f2})";
    }
}

