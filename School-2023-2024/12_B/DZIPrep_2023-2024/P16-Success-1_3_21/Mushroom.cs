using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Mushroom
{
    public Mushroom(int x, int y, int condition)
    {
        this.X = x;
        this.Y = y;
        this.Condition = condition;
    }

    public int X { get; private set; }
    public int Y { get;private set; }
    public int Condition { get;private set; }

}

