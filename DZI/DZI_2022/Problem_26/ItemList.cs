using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ItemList
{
    private readonly List<Item> items = new List<Item>();

    public int Size { get => items.Count; }
    public Item Get(int index)
    {
        if (index<0 || index > this.Size-1)
        {
            throw new ArgumentException("Invalid Index");
        }
        return items[index];
    }
    public void Add(Item item)
    {
        int insertIndex = 0;
        for (int i = 0; i < Size; i++)
        {
            if (item.CompareTo(items[i]) == 0)
            {
                throw new InvalidOperationException("Invalid Operation");
            }
            else if (item.CompareTo(items[i]) >0)
            {
                insertIndex=i+1;
            }
        }
        items.Insert(insertIndex, item);  
    }
    public override string ToString()
    {
        return String.Join(Environment.NewLine, items);
    }
}

