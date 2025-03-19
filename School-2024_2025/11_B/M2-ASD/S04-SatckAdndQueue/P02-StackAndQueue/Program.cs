public class Program
{
  public  static void Main(string[] args)
    {
        List<int> list = new List<int>() { 5, 10, 15, 25 };
        Stack<int> stack = new Stack<int>(list);
        Queue<int> queue = new Queue<int>(list);

        while (stack.Count > 0)
        {
            Console.WriteLine(stack.Pop());
        }
        Console.WriteLine("***********");

        while (queue.Count > 0)
        {
            Console.WriteLine(queue.Peek());
        }
    }
}