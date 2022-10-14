public class Item
{
    public Item(int weight, int price)
    {
        Weight = weight;
        Price = price;
    }
    public int Weight { get; set; }
    public int Price { get; set; }
    public override string ToString()
    {
        return $"(Weight: {Weight}, Price: {Price})";
    }
}

