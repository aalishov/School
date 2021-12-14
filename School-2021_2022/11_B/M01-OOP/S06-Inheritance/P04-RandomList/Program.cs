using System;

namespace CustomRandomList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RandomList list = new RandomList();
            for (int i = 0; i < 100; i++)
            {
                list.Add(i.ToString());
            }
            Console.WriteLine(list.RandomString());
            Console.WriteLine(list.RandomString());
            Console.WriteLine(list.RandomString());
            Console.WriteLine(list.RandomString());
            Console.WriteLine(list.RandomString());
        }
    }
}
