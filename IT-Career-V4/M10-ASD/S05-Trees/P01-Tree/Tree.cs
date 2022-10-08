public class Tree<T>
{
    // Стойност на възела
    private T value;

    // Деца на възела
    private IList<Tree<T>> children;

    public Tree(T value, params Tree<T>[] children)
    {
        this.value = value;
        this.children = children;
    }
    public void Print(int indent = 0)
    {
        Console.Write(new string(' ', 2 * indent));
        Console.WriteLine(this.value);
        foreach (var child in this.children)
        {
            child.Print(indent + 1);
        }
    }
}