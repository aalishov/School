using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<int> nums = new List<int>();
    static void Main()
    {
        ReadInitialData();

        Action();
    }

    private static void ReadInitialData()
    {
        nums = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();
    }

    private static void Action()
    {
        while (true)
        {
            string[] args = Console.ReadLine()
                .Split(' ')
                .ToArray();
            string cmd = args[0].ToLower();
            if (cmd == "print")
            {
                Console.WriteLine(string.Join(" ", nums));
                break;
            }

            string[] methodArgs = args.Skip(1).ToArray();

            ExecuteCommand(cmd, methodArgs);
        }
    }

    private static void ExecuteCommand(string cmd, string[] methodArgs)
    {
        switch (cmd)
        {
            case "add":
                Add(methodArgs);
                break;
            case "addmany":
                AddMany(methodArgs);
                break;
            case "contains":
                Contains(methodArgs);
                break;
            case "remove":
                Remove(methodArgs);
                break;
            default:
                break;
        }
    }

    public static void Add(string[] args)
    {
        int index = int.Parse(args[0]);
        int item = int.Parse(args[1]);
        nums.Insert(index, item);
    }
    public static void AddMany(string[] args)
    {
        int index = int.Parse(args[0]);
        List<int> items = args.Skip(1).Select(int.Parse).ToList();
        nums.InsertRange(index, items);
    }
    public static void Contains(string[] args)
    {
        int item = int.Parse(args[0]);
        Console.WriteLine(nums.Contains(item) ? nums.FindIndex(x => x == item) : -1); //if(nums.Contains(item)) {cw(nums.FindIndex(x => x == item))} else{cw(-1)}
    }
    public static void Remove(string[] args)
    {
        int index = int.Parse(args[0]);
        if (index >= 0 && index < nums.Count)
        {
            nums.RemoveAt(index);
        }
    }
}

