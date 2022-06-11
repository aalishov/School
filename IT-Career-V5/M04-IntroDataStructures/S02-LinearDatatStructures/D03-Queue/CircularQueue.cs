public class CircularQueue<T>
{
    private const int DefaultCapacity = 4;

    private T[] elements;
    private int startIndex;
    private int endIndex;

    public CircularQueue(int capacity = DefaultCapacity)
    {
        this.elements = new T[capacity];
        startIndex = 0;
        endIndex = 0;
    }

    public int Count { get; private set; }
    public void Enqueue(T element)
    {
        if (this.Count >= this.elements.Length)
        {
            this.Grow();
        }
        this.elements[this.endIndex] = element;
        this.endIndex = (this.endIndex + 1) % this.elements.Length;
        this.Count++;
    }
    public T Dequeue()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException("The queue is empty!");
        }
        T result = this.elements[startIndex];
        this.startIndex = (this.startIndex + 1) % this.elements.Length;
        this.Count--;
        return result;
    }
    public T Peek()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException("The queue is empty!");
        }
        return this.elements[startIndex];
    }
    public T[] ToArray()
    {
        T[] resultArr = new T[this.Count];
        CopyAllElementsTo(resultArr);
        return resultArr;
    }

    private void Grow()
    {
        T[] newElements = new T[2 * this.elements.Length];
        this.CopyAllElementsTo(newElements);
        this.elements = newElements;
        this.startIndex = 0;
        this.endIndex = this.Count;
    }
    private void CopyAllElementsTo(T[] resultArr)
    {
        int sourceIndex = this.startIndex;
        int destinationIndex = 0;
        for (int i = 0; i < this.Count; i++)
        {
            resultArr[destinationIndex] = this.elements[sourceIndex];
            sourceIndex = (sourceIndex + 1) % this.elements.Length;
            destinationIndex++;
        }
    }
}

