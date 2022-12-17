using System;
using System.Collections.Generic;
using System.Text;

public class Coffee : HotBeverage
{
    public Coffee(string name, double caffeine) : base(name, 3.5m, 50)
    {
        this.Caffeine = caffeine;
    }
    public double Caffeine { get; private set; }

}
