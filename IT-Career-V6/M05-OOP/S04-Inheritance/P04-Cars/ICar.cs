using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface ICar
{
    public string Model { get; }
    public string Color { get; }
    public string Start();
    public string Stop();
}

