public class Program
{
    private static List<string> words = new List<string>();
    public static void Main()
    {
        while (true)
        {
            try
            {
                string[] input = Console.ReadLine().Split(" ");
                Command command = Enum.Parse<Command>(input[0]);
                switch (command)
                {
                    case Command.Add:
                        words.AddRange(input.Skip(1));
                        break;
                    case Command.Remove:
                        int index = int.Parse(input[1]);
                        if (index > 0 && index < words.Count)
                        {
                            words.RemoveAt(index);
                        }
                        break;
                    case Command.Search:
                        if (words.Contains(input[1]))
                        {
                            Console.WriteLine(input[1]);
                        }
                        else
                        {
                            Console.WriteLine("Not contained.");
                        }
                        break;
                    case Command.Length:
                        int n = int.Parse(input[1]);
                        string output = words.Any(x => x.Length == n) ? string.Join(" -  ", words.Where(x => x.Length == n)) : "Not contained.";
                        Console.WriteLine(output);
                        break;
                    case Command.Insert:
                        index = int.Parse(input[1]);
                        string wordToInsert = input[2];
                        if (index > 0 && index <= words.Count)
                        {
                             words.Insert(index, wordToInsert);
                        }
                        else
                        {
                            Console.WriteLine("There are not enough items in the list.");
                        }
                        break;
                    case Command.Print:
                        Console.WriteLine(string.Join("; ", words));
                        break;
                    case Command.Update:
                        words = words.Select(x => new string(char.ToUpper(x[0]) + x.Substring(1))).ToList();

                        //for (int i = 0; i < words.Count; i++)
                        //{
                        //    char[] wordArray = words[i].ToCharArray();
                        //    char.ToUpper(wordArray[0]);
                        //    words[i] = new string(wordArray); 
                        //}
                        break;
                    case Command.END:
                        File.WriteAllLines("Output.txt", words);
                        Environment.Exit(0);
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid input...");
            }

        }
    }
    
}
public enum Command 
{
    None,
    Add,
    Update,
    Remove,
    Search,
    Length,
    Insert,
    Print,
    END
}



