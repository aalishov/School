using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    private static Stack<string> back = new Stack<string>();
    private static Stack<string> forward = new Stack<string>();
    private static string current = "blank page";
    public static void Main()
    {
        while (true)
        {
            string[] input = Console.ReadLine().Split(' ');
            string cmd = input[0].ToLower();

            switch (cmd)
            {
                case "url":
                    if (forward.Any())
                    {
                        while (forward.Any())
                        {
                            back.Push(forward.Pop());
                        }
                        back.Push(current);
                    }
                    else { back.Push(current);}
                    current = input[1];
                    break;
                case "back":
                    if (back.Any())
                    {
                        forward.Push(current);
                        current = back.Pop();
                    }
                    else { Console.WriteLine("Back isn't active..."); }
                    break;
                case "forward":
                    if (forward.Any())
                    {
                        back.Push(current);
                        current = forward.Pop();
                    }
                    else { Console.WriteLine("Forward isn't active..."); }
                    break;
                default:
                    Console.WriteLine("Error...");
                    break;
            }
            Console.WriteLine($"Visit: {current}");
        }
    }
}

