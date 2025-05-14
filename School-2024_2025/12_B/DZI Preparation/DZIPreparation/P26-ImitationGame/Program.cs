using System;
public class Program
{
    public static void Main()
    {
        string code = Console.ReadLine();
        while (true) 
        {
            string[] cmd = Console.ReadLine().Split("|");
            if (cmd[0] == "Decode")
            {
                break;
            }
            else if (cmd[0] == "Move")
            {
                int n = int.Parse(cmd[1]);
                string sub = code.Substring(0, n);
                code = code.Remove(0,n);
                code = code.Insert(code.Length, sub);
            }
            else if (cmd[0] == "Insert")
            {
                int index = int.Parse(cmd[1]);
                string value = cmd[2];
                code = code.Insert(index, value);
            }
            else if (cmd[0] == "ChangeAll")
            {
                string letter = cmd[1];
                string replacement = cmd[2];
                code = code.Replace(char.Parse(letter), char.Parse(replacement));
            }
        }
        Console.WriteLine($"The decrypted message is: {code}");
    }
}

