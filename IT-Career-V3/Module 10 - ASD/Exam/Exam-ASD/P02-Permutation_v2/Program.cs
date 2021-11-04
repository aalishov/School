using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> permuts = new List<string>();

        List<char> chars = Console.ReadLine().Split(' ').Select(x => x[0]).ToList();

        string line = string.Empty;

        while ((line = Console.ReadLine()) != "end")
        {
            List<char> currentChar = chars.ToList();

            if (line.Length != chars.Count) { continue; }

            bool isDifferent = false;

            foreach (var letter in line)
            {
                if (!currentChar.Any(x => x == letter))
                {
                    isDifferent = true;
                    break;
                }
                else { currentChar.Remove(letter); }
            }

            if (isDifferent) { continue; }

            permuts.Add(line);
        }

        if (permuts.Any())
        {
            foreach (var p in permuts.OrderBy(x => x))
            {
                Console.WriteLine(string.Join(" ", p.ToCharArray()));
            }
        }
        else
        {
            Console.WriteLine("No permutations...");
        }

    }
}


