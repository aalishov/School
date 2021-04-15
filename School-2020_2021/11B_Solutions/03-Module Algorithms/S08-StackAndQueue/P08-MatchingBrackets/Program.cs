using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        string expression = Console.ReadLine();
        Stack<int> index = new Stack<int>();

        for (int i = 0; i < expression.Length; i++)
        {
            char currentElement = expression[i];

            switch (currentElement)
            {
                case '(':
                    index.Push(i);
                    break;
                case ')':
                    int startIndex = index.Pop();
                    int length = (i - startIndex) + 1;
                    Console.WriteLine(expression.Substring(startIndex,length));
                    break;
            }
        }
    }
}

