namespace Ex04_P8_BalancedParentheses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Stack<char> left = new Stack<char>();
            Queue<char> right = new Queue<char>();

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];

                switch (c)
                {
                    case '{':
                    case '[':
                    case '(':
                        left.Push(c);
                        break;
                    default:
                        right.Enqueue(c);
                        break;
                }
            }

            bool isBalanced = false;


            if (left.Count == right.Count)
            {
                while (left.Any())
                {
                    char lChar = left.Pop();
                    char rChar = right.Dequeue();
                    bool isFigure = lChar == '{' && rChar == '}';
                    bool isSquare = lChar == '[' && rChar == ']';
                    bool isSimple = lChar == '(' && rChar == ')';

                    if (isFigure || isSquare || isSimple)
                    {
                        isBalanced = true;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }


}

