public class CustomArrayList 
{
    private const int InitialCapacity = 4;

    private object[] items;

    private int count;

    public int Count { get { return count; } }

    public CustomArrayList()
    {
        items = new object[InitialCapacity];
        count = 0;
    }

    public void Add(object item)
    {
        if (count == items.Length)
        {
            Resize();
        }
        items[count] = item;
        count++;
    }

    public void Insert(int index, object item)
    {
        if (index < 0 || index > count)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
        }
        if (count == items.Length)
        {
            Resize();
        }
        ShiftRight(index);
        items[index] = item;
        count++;
    }



    public void Clear()
    {
        items = new object[InitialCapacity];
    }

    public bool Contains(object item)
    {
        return IndexOf(item) != -1;
    }

    public object this[int index]
    {
        get
        {
            if (index < 0 || index >= count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
            }
            return items[index];
        }
        set
        {
            if (index < 0 || index >= count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
            }
            items[index] = value;
        }
    }

    public object RemoveAt(int index)
    {
        if (index < 0 || index >= count)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
        }
        object removedItem = items[index];
        ShiftLeft(index);
        items[count - 1] = null;
        count--;
        return removedItem;
    }

    public int Remove(object item)
    {
        int index = IndexOf(item);
        if (index != -1)
        {
            RemoveAt(index);
        }
        return index;
    }

    public int IndexOf(object item)
    {
        for (int i = 0; i < count; i++)
        {
            if (Equals(items[i], item))
            {
                return i;
            }
        }
        return -1;
    }

    private void ShiftRight(int index)
    {
        for (int i = count; i > index; i--)
        {
            items[i] = items[i - 1];
        }
    }

    private void ShiftLeft(int index)
    {
        for (int i = count; i > index; i--)
        {
            items[i] = items[i - 1];
        }
    }

    private void Resize()
    {
        int newCapacity = items.Length * 2;
        object[] newItems = new object[newCapacity];
        Array.Copy(items, newItems, items.Length);
        items = newItems;
    }
}
