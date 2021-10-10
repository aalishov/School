using System;
using System.Collections.Generic;
using System.Text;


public class SunProvider : Provider
{
    public SunProvider(string id, double energyOutput) : base(id, energyOutput*1.25)
    {
    }
}

