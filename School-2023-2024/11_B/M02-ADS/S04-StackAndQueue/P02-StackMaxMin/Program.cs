namespace P02_StackMaxMin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                List<int> list = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
                int cmd = list[0];
                if (cmd == 1)
                {
                    stack.Push(list[1]);
                }
                else if (cmd == 2)
                {
                    stack.Pop();
                }
                else if(cmd == 3)
                {
                    Console.WriteLine(stack.Max());
                }
                else if (cmd == 4)
                {
                    Console.WriteLine(stack.Min());
                }
            }
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
