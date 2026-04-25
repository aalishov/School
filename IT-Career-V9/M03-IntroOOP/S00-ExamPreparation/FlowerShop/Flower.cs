public class Flower
{
    private double price;

    public Flower(string type, string color, double price)
    {
        Type = type;
        Color = color;
        Price = price;
    }


    public string Type { get; private set; }

    public string Color { get; private set; }

    public double Price
    {
        get => price; private set
        {
            if (value > 100)
            {
                throw new ArgumentException("Invalid flower price!");
            }
            price = value;
        }
    }

    public override string ToString()
    {
        return $"Flower {Type} with color {Color} costs {Price:f2}";
    }

}

