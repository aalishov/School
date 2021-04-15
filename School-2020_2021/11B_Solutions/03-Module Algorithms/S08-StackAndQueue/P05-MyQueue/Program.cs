using System;

namespace P05_MyQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue<int> numbers = new MyQueue<int>();
            numbers.Enqueue(1);
            numbers.Enqueue(2);
            numbers.Enqueue(3);
            numbers.Enqueue(4);
            numbers.Enqueue(5);
            numbers.Enqueue(6);

            while (numbers.Count > 0)
            {
                int num = numbers.Dequeue();
                Console.WriteLine(num);
                //1, 2, 3, 4, 5, 6  
            }
        }
    }
}
