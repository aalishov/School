
public class Program
{
    public static void Main()
    {
        string input = Console.ReadLine();
        Stack<char> stack = new Stack<char>();
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '(' || input[i] == '[' || input[i] == '{')
            {
                stack.Push(input[i]);
            }
            else if (input[i] == ')' || input[i] == ']' || input[i] == '}')
            { int element=stack.Pop();
                bool isMatch = element == '(' && input[i] == ')' || element == '{' && input[i] == '}' || element == '[' && input[i] == ']';
               
                if (!isMatch)
                {
                    Console.WriteLine("No");
                    Environment.Exit(0);
                }
            }

        }
        if (stack.Count == 0)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

