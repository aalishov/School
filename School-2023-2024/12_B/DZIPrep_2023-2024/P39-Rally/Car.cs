using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Car
{
    public Car(string brand, int hPower)
    {
        Brand = brand;
        HPower = hPower;
    }

    public string Brand { get; set; }

    public int HPower { get; set; }

    public override string ToString()
    {
        return $"{Brand},{HPower}";
    }
}