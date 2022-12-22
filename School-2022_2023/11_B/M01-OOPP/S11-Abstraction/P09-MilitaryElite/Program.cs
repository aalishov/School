using System;
using System.Collections.Generic;
using System.Linq;
internal class Program
{
    static void Main()
    {
        List<ISoldier> soldiers = new List<ISoldier>();
        bool end = false;
        while (end == false)
        {
            string[] command = Console.ReadLine().Split(' ');
            switch (command[0])
            {
                case "Private":
                    Private p = new Private(int.Parse(command[1]), command[2], command[3], decimal.Parse(command[4]));
                    soldiers.Add(p);
                    break;
                case "LeutenantGeneral":
                    LieutenantGeneral lg = new LieutenantGeneral(int.Parse(command[1]), command[2], command[3], decimal.Parse(command[4]));
                    soldiers.Add(lg);
                    for (int i = 5; i < command.Length; i++)
                    {
                        Private s = (Private)soldiers.FirstOrDefault(x => x.Id == int.Parse(command[i]));
                        if (s != null)
                        {
                            lg.Add(s);
                        }
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
