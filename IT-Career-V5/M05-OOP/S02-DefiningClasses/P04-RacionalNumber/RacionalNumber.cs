using System;
using System.Collections.Generic;
using System.Text;

public class RacionalNumber
{
    public int Numerator { get; set; }
    public int Denumerator { get; set; }
    public override string ToString()
    {
        return $"{Numerator}/{Denumerator}";
    }
}

