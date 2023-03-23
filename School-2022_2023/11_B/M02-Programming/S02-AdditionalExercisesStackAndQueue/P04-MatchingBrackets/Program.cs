using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        string input = Console.ReadLine();

        Stack<int> indexes = new Stack<int>();

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '(')
            {
                indexes.Push(i);
            }
            else if (input[i] == ')')
            {
                int start = indexes.Pop();
                int length = i - start+1;
                Console.WriteLine(input.Substring(start,length));
            }
        }
    }
}

