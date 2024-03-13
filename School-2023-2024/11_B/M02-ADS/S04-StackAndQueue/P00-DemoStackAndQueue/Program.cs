public class Program
{
    public static void Main()
    {
        List<int> list = new List<int>() { 10, 20, 30, 40, 50 };
        Stack<int> stack = new Stack<int>(list);
        Queue<int> queue = new Queue<int>(list);

        Console.WriteLine($"Stack peek: {stack.Peek()}");
        Console.WriteLine($"Queue peek: {queue.Peek()}");

        Console.WriteLine($"Stakc count: {stack.Count()}");
        Console.WriteLine($"Queue count: {queue.Count()}");

        Console.WriteLine($"Print stack: {string.Join(", ",stack)}");
        Console.WriteLine($"Print queue: {string.Join(", ", queue)}");

    }
}

