public class Program
{
    public static void Main()
    {
        LinkedList<int> nums = new LinkedList<int>();

        nums.AddFirst(2);
        nums.AddFirst(1);
        nums.AddLast(3);
        nums.AddLast(4);
        nums.AddLast(5);
        nums.AddLast(6);
        nums.AddLast(7);
        nums.AddLast(8);
        nums.AddLast(9);
        nums.AddLast(10);

        var node = nums.Find(5);

        while (node != null)
        {
            Console.Write(node.Value);
            node = node.Previous;
        }

        Console.WriteLine();
        node = nums.Find(5);
        while (node != null)
        {
            Console.Write(node.Value);
            node = node.Next;
        }
        Console.WriteLine();
    }
}


