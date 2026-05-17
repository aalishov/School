using System.Collections;

public class ArrayList<T> : IEnumerable<T>
{
    private const int InitialCapacity = 4;
    private T[] items;

    public ArrayList()
    {
        items = new T[InitialCapacity];
        Count = 0;
    }

    public int Count { get; private set; }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= Count)
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
            return items[index];
        }
        set
        {
            if (index < 0 || index >= Count)
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
            items[index] = value;
        }
    }
    public void Add(T item)
    {
        if (Count == items.Length)
        { Resize(); }
        items[Count] = item;
        Count++;
    }

    private void Resize()
    {
        int newCapacity = items.Length * 2;
        T[] newItems = new T[newCapacity];
        Array.Copy(items, newItems, items.Length);
        items = newItems;
    }

    public T RemoveAt(int index)
    {
        if (index < 0 || index >= Count)
            throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
        T removedItem = items[index];
        Shift(index);
        items[Count - 1] = default(T);
        Count--;
        if (Count <= items.Length / 4)
        {
            Shrink();
        }

        return removedItem;
    }

    private void Shift(int index)
    {
        for (int i = index; i < Count - 1; i++)
        {
            items[i] = items[i + 1];
        }
    }

    private void Shrink()
    {
        int newCapacity = items.Length / 2;
        if (newCapacity < InitialCapacity)
            newCapacity = InitialCapacity;
        T[] newItems = new T[newCapacity];
        Array.Copy(items, newItems, Count);
        items = newItems;
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < Count; i++)
        {
            yield return items[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
