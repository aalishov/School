internal class Program
{
    public static void Main(string[] args)
    {
        List<int> list = new List<int>();

        //LIFO - last in, frist out
        Stack<int> stack = new Stack<int>();

        //FIFO - first in, frist out
        Queue<int> queue = new Queue<int>();

        list.Add(1);
        list.Add(2);
        list.Add(3);

        //Добавяне
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        //Премахване
        stack.Pop();
        stack.Pop();

        //Добавяне
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        //Премахване
        queue.Dequeue();
        queue.Dequeue();

        int num = stack.Peek();


        var items = new int[3][];
        var nums = new int[2, 1, 1];
        var items2 = new Stack<int>(new List<int>() { 1, 23, 3, });

      
    }
}