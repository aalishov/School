using System.Collections.Generic;
using System.Linq;

public class Deque<T>
{
    private const int DefaultCapacity = 16;

    private readonly List<T> data;

    public Deque() : this(DefaultCapacity)
    {
        //празен конструктор, задава капацитета на дека на стойността по подразбиране (16)
        data = new List<T>(DefaultCapacity);
    }
    public Deque(int capacity)
    {
        //създава дека с точно зададен капацитет
        data = new List<T>(capacity);
    }
    public Deque(IEnumerable<T> collection)
         : this(collection.Count())
    {
        //създава дека с капацитет съответстващ на посочената колекция и прехвърля елементите от колекцията в дека
        data = new List<T>(collection.Count());
        data.AddRange(collection);
    }
    public int Capacity { get { return data.Capacity; } }//показва капацитета
    public int Count { get { return data.Count; } } //показва броят елементи
    public void AddFront(T item)
    {
        //добавя елемент отпред
        data.Insert(0, item);
    }
    public void AddBack(T item)
    {
        //добавя елемент отзад
        data.Add(item);
    }
    public T RemoveFront()
    {
        //връща и премахва елемента отпред
        T item = data[0];
        data.RemoveAt(0);
        return item;
    }
    public T RemoveBack()
    {
        //връща и премахва елемента отзад
        T item = data[Count - 1];
        data.RemoveAt(Count - 1);
        return item;
    }
    public T GetFront()
    {
        //връща, без да премахва, елемента отпред
        return data[0];
    }
    public T GetBack()
    {
        //връща, без да премахва, елемента отзад
        return data[Count- 1];
    }

    public override string ToString()
    {
        return $"{string.Join(", ",data)}";
    }
}

