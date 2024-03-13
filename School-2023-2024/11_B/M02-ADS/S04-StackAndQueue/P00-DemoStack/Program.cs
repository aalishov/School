public class Program
{
    public static void Meth1()
    {
        Thread.Sleep(1000);
    }
    public static void Meth2()
    {
        Meth1();
    }
    public static void Meth3()
    {
        Meth2();
    }
    public static void Main()
    {
        List<int> list = new List<int>();

        Meth3();

        //LIFO
        Stack<int> stack = new Stack<int>();
        stack.Push(10); 
        stack.Push(20);
        stack.Push(30);
        stack.Push(40);
        Console.WriteLine($"Stack count: {stack.Count}");

        // int num=stack.Pop();

        // Console.WriteLine(stack.Pop());

        //Console.WriteLine($"Count: {stack.Count}");


        //Print - variant 1
        //int count=stack.Count;

        //for (int i = 0; i < count; i++)
        //{
        //    Console.WriteLine(stack.Pop());
        //}


        while (stack.Count>0)
        {
            Console.WriteLine(stack.Pop());
        }
    }
}

