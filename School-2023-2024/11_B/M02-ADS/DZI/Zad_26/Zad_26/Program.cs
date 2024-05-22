public class Program
{
    private static List<string> words = new List<string>();

    public static void Main()
    {
        while (true)
        {
            string[] input = Console.ReadLine().Split(" ");

            if (input[0] == "END")
            {
                break;
            }
            else if (input[0] == "Add")
            {
                //words.AddRange(input.Skip(1));
                for (int i = 1; i < input.Length; i++)
                {
                    words.Add(input[i]);
                }
            }
            else if (input[0] == "Update")
            {
                for (int i = 0; i < words.Count; i++)
                {
                    char[] newWord = words[i].ToCharArray();
                    newWord[0] = char.ToUpper(newWord[0]);
                    words[i] = new string(newWord);

                }
            }
            else if (input[0] == "Remove")
            {
                int index = int.Parse(input[1]);
                if (index >= 0 && index < words.Count)
                {
                    words.RemoveAt(index);
                }
            }
            else if (input[0] == "Search")
            {
                if (words.Contains(input[1]))
                {
                    Console.WriteLine(input[1]);
                }
                else
                {
                    Console.WriteLine("Not contained.");
                }
            }
            else if (input[0] == "Length")
            {
                int l = int.Parse(input[1]);
                if (words.Any(x => x.Length == l))
                {
                    Console.WriteLine(string.Join("-", words.Where(x => x.Length == l)));
                }
                else
                {
                    Console.WriteLine("Not contained.");
                }
            }
            else if (input[0] == "Insert")
            {
                int index = int.Parse(input[1]);
                string word = input[2];
                if (index >= 0 && index < words.Count)
                {
                    words.Add(word);
                }
                else
                {
                    Console.WriteLine("There are not enough items in the list.");
                }
            }
            else if (input[0]=="Print")
            {
                Console.WriteLine(string.Join(" - ", words));
            }
        }
    }
}

