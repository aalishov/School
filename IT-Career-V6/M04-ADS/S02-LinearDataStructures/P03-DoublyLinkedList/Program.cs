
public class Program
{
    public static void Main()
    {
        LinkedList<int> list = new LinkedList<int>();
        list.AddFirst(10);
        list.AddFirst(20);
        list.AddFirst(30);


        System.Console.WriteLine($"Count: {list.Count}");
        System.Console.WriteLine($"Head => {list.Head.Value}");
        System.Console.WriteLine($"Tail => {list.Tail.Value}");
        System.Console.WriteLine(list.Head.Next.Value);


    }
}