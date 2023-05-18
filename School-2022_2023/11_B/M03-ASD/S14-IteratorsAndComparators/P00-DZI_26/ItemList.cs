using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ItemList:IEnumerable
{
    private readonly SortedSet<Item> items = new SortedSet<Item>();

    public int Size { get => items.Count; }

    public Item Get(int index)
    {
        if (index < 0 || index >= Size)
        {
            throw new IndexOutOfRangeException("Invalid index!");
        }

        return items.ToArray()[index];
    }

    public void Add(Item item)
    {
        if (items.Contains(item))
        {
            throw new ArgumentException($"Invalid item - {item}!");
        }

        items.Add(item);
    }

    public IEnumerator GetEnumerator()
    {
        foreach (var item in items)
        {
            yield return item;
        }
    }
}

