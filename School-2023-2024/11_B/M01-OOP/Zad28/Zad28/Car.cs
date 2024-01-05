using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad28
{
    public class Car
    {
        public Car(string brand, int hPower)
        {
            Brand = brand;
            HPower = hPower;
        }

        public string Brand { get; private set; }
        public int HPower { get; private set; }

        public override string ToString()
        {
            return $"{Brand},{HPower}";
        }
    }
}
