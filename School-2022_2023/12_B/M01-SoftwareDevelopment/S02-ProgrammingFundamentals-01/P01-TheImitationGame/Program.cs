using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        List<char> input = Console.ReadLine().ToCharArray().ToList();
        string[] cmd = null;
        while ((cmd = Console.ReadLine().Split("|").ToArray())[0] != "Decode")
        {
            switch (cmd[0])
            {
                case "Move":
                    int leters = int.Parse(cmd[1]);
                   List<char> movedLetters = input.Take(leters).ToList();
                    input.RemoveRange(0, leters);
                    input.AddRange(movedLetters);
                    break;
                case "Insert":
                    int index = int.Parse(cmd[1]);
                    List<char> letters = cmd[2].ToCharArray().ToList();
                    input.InsertRange(index--,letters);
                    break;
                case "ChangeAll":
                    string substring = cmd[1];
                    string replacement= cmd[2];
                    string newString = new string(input.ToArray());
                    string result = newString.Replace(substring, replacement);
                    input = result.ToCharArray().ToList();                    
                    break;
            }
        }
        Console.WriteLine($"The decrypted message is: {String.Join("", input)}");
    }
}

