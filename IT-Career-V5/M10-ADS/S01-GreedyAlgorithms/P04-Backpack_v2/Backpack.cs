using System.Collections.Generic;
using System.Linq;

public class Backpack
{
    public Backpack(int maxWeight=10)
    {
        MaxWeight = maxWeight;
        this.Items = new List<Item>();
    }
    public int MaxWeight { get; set; }
    public List<Item> Items { get; set; }
    public int Price { get=>Items.Sum(x=>x.Price);}
    public int Weight { get => Items.Sum(x => x.Weight); }
    public void Add(Item item)
    {
        //if (this.Items.Sum(x=>x.Weight)+item.Weight<=MaxWeight)
        //{
        //    this.Items.Add(item);
        //}

        this.Items.Add(item);
    }

    public override string ToString()
    {
        return $"Price: {this.Price}, Weight: {this.Weight}, Items: {string.Join(", ",Items)}";
    }
}

