public class ArrayStack<T>
{
    private const int InitialCapacity = 4;

    private T[] elements;
    public ArrayStack(int capacity = InitialCapacity)
    {
        this.elements = new T[capacity];
    }
    public int Count { get; private set; }
    public bool Contains(T element)
    {
        for (int i = 0; i < this.Count; i++)
        {
            if (element.Equals(elements[i]))
            {
                return true;
            }
        }
        return false;
    }
    public void Push(T element)
    {
        if (this.Count >= this.elements.Length)
        {
            Grow();
        }
        this.elements[this.Count] = element;
        this.Count++;
    }
    public T Pop()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException("The stack is empty!");
        }
        T element = this.elements[this.Count - 1];
        this.Count--;
        return element;
    }
    public T Peek()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException("The stack is empty!");
        }
        return this.elements[this.Count - 1];
    }
    public T[] ToArray()
    {
        T[] resultArr = new T[this.Count];
        for (int i = 0; i < this.Count; i++)
        {
            resultArr[i] = this.elements[i];
        }
        return resultArr;
    }
    private void Grow()
    {
        T[] newElements = new T[this.elements.Length * 2];
        for (int i = 0; i < this.Count; i++)
        {
            newElements[i] = this.elements[i];
        }
        this.elements = newElements;
    }
}

