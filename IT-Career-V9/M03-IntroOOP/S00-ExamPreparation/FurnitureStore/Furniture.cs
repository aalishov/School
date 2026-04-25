public class Furniture
{
    private double price;

    public Furniture(string type, string color, double price)
    {
        Type = type;
        Color = color;
        Price = price;
    }

    public string Type { get; set; }

    public string Color { get; set; }

    public double Price
    {
        get { return price; }
        set
        {
            if (value > 100)
            {
                throw new ArgumentException("Invalid furniture price!");
            }
            price = value;
        }
    }

    public override string ToString()
    {
        return $"Furniture {Type} with color {Color} costs {Price:f2}";
    }
}

