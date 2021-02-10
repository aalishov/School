namespace D03_Stack
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            int[] nums = new int[] { 1, 2, 3 };

            Stack<int> stack = new Stack<int>(nums);

            //ArrayStack stack1 = new ArrayStack();
            //stack.Push(12);
            //stack.Push(15);
            //Console.WriteLine(stack.Peek());

            while (stack.Any())
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
