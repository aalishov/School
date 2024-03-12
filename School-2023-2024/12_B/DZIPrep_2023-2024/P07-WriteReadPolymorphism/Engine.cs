using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Engine
{

    private List<string> studentNames = new List<string>();
    public IReader Reader { get; set; }
    public IWriter Writer { get; set; }

    public Engine(IReader reader, IWriter writer)
    {
        Reader = reader;
        Writer = writer;
        Action();
    }
    
    public void Action()
    {
        Writer.Write("Input student names, separated by space");
        List<string> studentNamesList = Reader.Read().Split(' ').ToList();
        while (true)
        {
            Writer.Write("Select either Add or Remove");
            string cmd = Reader.Read();
            switch (cmd)
            {
                case "Add":
                    Writer.Write("Input a name to add: ");
                    string name = Reader.Read();
                    studentNamesList.Add(name);
                    Writer.Write("Successfully added!");
                    break;
                case "Remove":
                    Writer.Write("Input a name to remove: ");
                    string name1 = Reader.Read();
                    studentNamesList.Remove(name1);
                    Writer.Write("Successfully removed!");
                    break;
                case "End":
                    return;
                default:
                    Writer.Write("No such command!");
                    break;
            }
        }
    }
}

