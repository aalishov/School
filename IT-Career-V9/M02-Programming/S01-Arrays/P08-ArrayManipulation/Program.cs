public class Program
{
    public static void Main()
    {
        string[] words = Console.ReadLine().Split(" ").ToArray();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(" ").ToArray();
            string cmd = input[0];

            switch (cmd)
            {
                case "Distinct":
                    words = words.Distinct().ToArray();
                    break;
                case "Reverse":
                    Array.Reverse(words);
                    break;
                case "Replace":
                    int index = int.Parse(input[1]);
                    string newWord = input[2];
                    if (index < 0 || index >= words.Length)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else
                    {
                        words[index] = newWord;
                    }
                    break;
            }
        }
        Console.WriteLine(string.Join(", ", words));
    }
}

