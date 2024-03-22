public class Program
{
    public static void Main()
    {
        string b = Console.ReadLine();
        Stack<char> s = new Stack<char>();
        int countT1 = 0;
        int countT2 = 0;
        int countT3 = 0;
        int countT4 = 0;

        for (int i = 0; i < b.Length; i++)
        {
            if (b[i] == '(' || b[i] == '{' || b[i] == '[' || b[i] == '<')
            {
                s.Push(b[i]);
            }
            else if (b[i] == ')' || b[i] == '}' || b[i] == ']' || b[i] == '>')
            {
                char elememt = s.Pop();
                if (elememt == '(' && b[i] == ')' && s.Any())
                {
                    countT1++;
                }
                else if (elememt == '{' && b[i] == '}' && s.Any())
                {
                    countT2++;
                }
                else if (elememt == '[' && b[i] == ']' && s.Any())
                {
                    countT3++;
                }
                else if (elememt == '<' && b[i] == '>' && s.Any())
                {
                    countT4++;
                }
                else
                {
                    Console.WriteLine("Invalid expression");
                    Environment.Exit(0);
                }
            }
        }
        if (!s.Any())
        {
            Console.WriteLine($"Brackets type () - count {countT1}");
            Console.WriteLine($"Brackets type {{}} - count {countT2}");
            Console.WriteLine($"Brackets type [] - count {countT3}");
            Console.WriteLine($"Brackets type <> - count {countT4}");
        }
        else
        {
            Console.WriteLine("Invalid expression");
        }
    }
}

