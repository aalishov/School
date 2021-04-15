using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Stack<int> numbers = new Stack<int>(arr);

        while (true)
        {
            string[] input = Console.ReadLine().Split(' ');

            string cmd = input[0].ToLower();

            if (cmd == "end")
            {
                break;
            }

            switch (cmd)
            {
                case "add":
                    numbers.Push(int.Parse(input[1]));
                    numbers.Push(int.Parse(input[2]));
                    Console.WriteLine($"Stack: {string.Join(" ",numbers.ToArray().Reverse())}");
                    break;
                case "remove":
                    int removeCount = int.Parse(input[1]);
                    if (removeCount<=numbers.Count)
                    {
                        //Премахваме елементите от стека
                        for (int i = 0; i < removeCount; i++)
                        {
                            Console.WriteLine($"Pop: {numbers.Pop()}");
                        }
                    }
                    break;
            }
        }

        Console.WriteLine($"Sum: {numbers.ToArray().Sum()}");
    }
}

