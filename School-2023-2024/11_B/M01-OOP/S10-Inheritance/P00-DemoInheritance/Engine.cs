using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Engine
{

    public Engine()
    {
        Type = "Petrol";
        HorsePower = 180;
    }

    public Engine(string type, int horsePower)
    {
        Type = type;
        HorsePower = horsePower;
    }

    public string Type { get; set; }
    public int HorsePower { get; set; }
}

