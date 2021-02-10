using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Enter elements: ");
        string[] words = Console.ReadLine()
            .Split(' ')
            .ToArray();
        Console.Write("Enter commands count: ");
        int n = 0;
        int.TryParse(Console.ReadLine(), out n);

        for (int i = 0; i < n; i++)
        {
            PrintMenu();
            string[] line = Console.ReadLine()
                .Split(' ')
                .ToArray();

            string cmd = line[0];

            switch (cmd)
            {
                case "Distinct":
                    words = words.Distinct().ToArray();
                    break;
                case "Reverse":
                    Array.Reverse(words);
                    break;
                case "Replace":
                    bool isNum = int.TryParse(line[1], out _);
                    if (isNum)
                    {
                        int index = int.Parse(line[1]);
                        if (index>=0&&index<words.Length)
                        {
                            string newElement = line[2];
                            words[index] = newElement;
                        }
                        else
                        {
                            Console.WriteLine("=>Index out of range!");
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("=>Incorect format!");
                    }
                    break;
                default:
                    Console.WriteLine("Error command!");
                    break;
            }

            Console.WriteLine($"{cmd}=>{string.Join(", ", words)}");
        }
    }

    public static void PrintMenu()
    {
        Console.WriteLine(new string('-',50));
        Console.WriteLine("Replace index newElement");
        Console.WriteLine("Distinct");
        Console.WriteLine("Revese");
        Console.Write("Enter command: ");
    }
}

