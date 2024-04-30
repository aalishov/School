using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ItemList_
{
    private readonly int count;
    private List<Item> items = new List<Item>();
    public int Count
    {
        get
        {
            return this.items.Count;
        }
    }
    public Item Get(int index)
    {
        return items[index];
    }
    public void Add(Item item)
    {
        for (int i = 0; i < this.Count; i++)
        {
            if (items[i].CompareTo(item)>0)
            {
                items.Insert(i, item);
                return;
            }
            else if (items[i].CompareTo(item) == 0)
            {
                throw new InvalidOperationException("Equal items");
            }
        }
        items.Add(item);
    }
}
