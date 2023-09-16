
public class Box<T>
{
    private List<T> items;

    public Box(string color)
    {
        Color = color;
        items = new List<T>();
    }

    public string Color { get; set; }

    public void Add(T item) { this.items.Add(item); }

    public T Remove()
    {
        if (items.Count<=0)
        {
            return default;
        }
        T item= this.items[0];
        this.items.RemoveAt(0);
        return item;
    }

    public string GetItems()
    {
        return $"{items.FirstOrDefault().GetType().FullName}: {string.Join(", ", this.items)}";   
    }

    public override string ToString()
    {
        return GetItems();
    }
}

