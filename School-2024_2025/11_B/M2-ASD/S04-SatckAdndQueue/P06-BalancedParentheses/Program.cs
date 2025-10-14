public class Program
{
    public static void Main()
    {
        char[] chars = Console.ReadLine().ToCharArray();

        Stack<char> stack = new Stack<char>();

        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i] == '(' || chars[i] == '{' || chars[i] == '[')
            {
                stack.Push(chars[i]);
            }
            else
            {
                if (stack.Count==0)
                {
                    Console.WriteLine("NO");
                    Environment.Exit(0);
                }
                char bracket = stack.Pop();
                if (bracket == '(' && chars[i] == ')')
                {
                    continue;
                }
                else if (bracket == '[' && chars[i] == ']')
                {
                    continue;
                }
                else if (bracket == '{' && chars[i] == '}')
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("NO");
                    Environment.Exit(0);
                }
            }
        }
        if (stack.Count == 0)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}