using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<int> nums = ReadNums();

        while (true)
        {
            string[] info = Console.ReadLine().Split(' ');
            string cmd = info[0].ToLower();
            switch (cmd)
            {
                case "add":
                    nums.Add(int.Parse(info[1]));
                    break;
                case "insert":
                    int element = int.Parse(info[2]);
                    int index = int.Parse(info[1]);

                    if (index > nums.Count || index < 0)
                    {
                        Console.WriteLine("Invalid Index");
                    }
                    else
                    {
                        nums.Insert(element, index);
                    }
                    break;
                case "remove":
                    int index1 = int.Parse(info[1]);

                    if (index1 > nums.Count || index1 < 0)
                    {
                        Console.WriteLine("Invalid Index");
                    }
                    else
                    {
                        nums.RemoveAt(index1);
                    }
                    break;
                case "end":
                    Environment.Exit(0);
                    break;
                case "Shift":
                    string typeShift = info[1];
                    int count = int.Parse(info[2]);
                    switch (typeShift)
                    {
                        case "left":
                            for (int i = 0; i < count; i++)
                            {
                                int number = nums[0];
                                nums.RemoveAt(0);
                                nums.Add(number);
                            }
                            break;
                        case "right":
                            for (int i = 0; i < count; i++)
                            {
                                int number = nums[nums.Count - 1];
                                nums.RemoveAt(nums.Count - 1);
                                nums.Insert(0, number);
                            }
                            break;
                        default:
                            break;
                    }
                    break;
            }
            Console.WriteLine(String.Join(" ", nums));
        }
    }

    private static List<int> ReadNums()
    {
        return Console.ReadLine().Split(' ').Select(int.Parse).ToList();
    }
}


