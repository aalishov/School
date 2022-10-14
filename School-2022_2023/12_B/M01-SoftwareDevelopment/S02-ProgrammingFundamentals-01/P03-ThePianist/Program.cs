using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main()
    {
        int nrows = int.Parse(Console.ReadLine());
        List<string> pieces = new List<string>();
        for (int i = 1; i <= nrows; i++)
        {
            pieces.Add(Console.ReadLine());
        }
        
        while (true)
        {
            string[] input = Console.ReadLine().Split('|');
            switch (input[0])
            {
                case "Add":
                   
                    bool include = false;
                    foreach (var component in pieces)
                    {
                        if (component.Split('|').FirstOrDefault() == input[1])
                        {
                            include = true;
                            break;
                        }
                    }
                    if (include)
                    {
                        Console.WriteLine($"{input[1]} is already in the collection!");
                    }
                    else
                    {
                        string piece = String.Join('|', input.Skip(1));
                        pieces.Add(piece);
                        Console.WriteLine($"{input[1]} by {input[2]} in {input[3]} added to the collection!");
                    }
                    break;
                case "Remove":
                    bool inpiece = false;
                    string removedPiece = String.Empty;
                    foreach (var component in pieces)
                    {
                        if (component.Split('|').FirstOrDefault() == input[1])
                        {
                            inpiece = true;
                            removedPiece = component;
                            break;
                        }
                    }
                    if (inpiece)
                    {
                        
                        pieces.Remove(removedPiece);
                        Console.WriteLine($"Successfully removed {input[1]}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {input[1]} does not exist in the collection.");
                    }
                    break;
                case "ChangeKey":
                    bool isInTheCOllection = false;
                    int index = -1;
                    for (int i = 0; i < pieces.Count; i++)                  
                    {
                        
                        if (pieces[i].Split('|').FirstOrDefault() == input[1])
                        {
                            isInTheCOllection = true;
                            index = i;
                            break;
                        }
                    }
                    string[] newPiece = pieces[index].Split('|');
                    
                    if (isInTheCOllection)
                    {
                        string result = $"{newPiece[0]}|{newPiece[1]}|{input[2]}";
                        pieces.RemoveAt(index);
                        pieces.Insert(index, result);
                        Console.WriteLine($"Changed the key of {newPiece[0]} to {input[2]}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {newPiece[0]} does not exist in the collection.");
                    }
                    break;
                case "Stop":
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
            //Console.WriteLine(String.Join("\n\r",pieces));
        }
    }
}

