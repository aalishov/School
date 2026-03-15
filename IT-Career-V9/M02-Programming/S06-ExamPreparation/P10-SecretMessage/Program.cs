using System.Text;

public class Program
{
    public static void Main()
    {
        StringBuilder secretMessage = new StringBuilder(Console.ReadLine());

        while (true)
        {
            string[] input = Console.ReadLine().Split(":|:");
            string cmd = input[0];
            if (cmd == "Reveal") { Console.WriteLine($"You have a new text message: {secretMessage}"); break; }
            switch (cmd)
            {
                case "InsertSpace":
                    int index = int.Parse(input[1]);
                    secretMessage.Insert(index, " ");
                    break;
                case "Reverse":
                    string substring = input[1];
                    secretMessage.Remove(secretMessage.ToString().IndexOf(substring), substring.Length);
                    secretMessage.Append(substring.Reverse().ToArray());
                    break;
                case "ChangeAll":
                    string oldSubstring = input[1];
                    string newSubstring = input[2];
                    secretMessage.Replace(oldSubstring, newSubstring);
                    break;
                default:
                    break;
            }

            Console.WriteLine(secretMessage);
        }

    }
}