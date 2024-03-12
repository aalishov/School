using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ConsoleReader : IReader
{
    public string Read()
    {
        return Console.ReadLine();
    }
}


