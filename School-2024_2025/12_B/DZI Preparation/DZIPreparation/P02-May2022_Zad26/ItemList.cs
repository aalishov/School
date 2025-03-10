using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ItemList
{
    private List<Item> items = new List<Item>();

    public int Size { get { return items.Count; } }

    public void Add(Item item)
    {
        //Variant 1 - по-правилен
        int index = 0;

        for (int i = 0; i < items.Count; i++)
        {
            if (item.CompareTo(items[i]) < 0)
            {
                index = i;
                items.Insert(i, item); return;
            }
            else if (item.CompareTo(items[i]) == 0)
            {
                throw new ArgumentException("Item already exyst!");
            }
        }
        items.Add(item);

        //Variant 2
        //items.Add(item);
        //items = items.OrderBy(x => x.Description)
        //    .ThenBy(x => x.Price)
        //    .ToList();
    }

    public Item Get(int index)
    {
        return items[index];
    }

    public override string ToString()
    {
        return string.Join("\n\r", items);
    }
}
