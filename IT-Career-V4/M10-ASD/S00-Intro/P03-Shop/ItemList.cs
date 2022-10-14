using System;
using System.Collections.Generic;
using System.Text;

public class ItemList
{
    private readonly List<Item> items = new List<Item>();

    public int Size { get { return this.items.Count; } }
    public Item Get(int index)
    {
        if (index < 0 || index >= this.Size)
        {
            throw new IndexOutOfRangeException("Invalid index");
        }
        return this.items[index];
    }

    public void Add(Item item)
    {
        this.items.Add(item);
    }
}

