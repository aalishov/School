namespace P02_ArrayStack
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            // Статична имплементация на стек (FILO or LIFO)
            var stack = new ArrayStack<int>();

            // Добавяме
            var items = Console.ReadLine().Split().Select(int.Parse).ToArray();
            foreach (var item in items)
            {
                stack.Push(item);
            }

            // Печат
            while (stack.Count > 0)
            {
                Console.Write("{0} ", stack.Pop());
            }
        }
    }
}
