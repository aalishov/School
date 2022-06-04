public class Flower
{
    private double price;

    public Flower(string type, string color, double price)
    {
        this.Type = type;
        this.Color = color;
        this.Price = price;
    }

    public string Type { get; private set; }
    public string Color { get; private set; }
    public double Price
    {
        get { return this.price; }
        private set
        {
            if (value>100)
            {
                throw new ArgumentException("Invalid flower price!");
            }
            this.price = value;
        }
    }
    public override string ToString()
    {
        return $"Flower {this.Type} with color {this.Color} costs {this.Price:f2}";
    }
}

