using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad28
{
    public class Pilot : Person
    {
        public Pilot(string name, int age, Car car, string category) : base(name, age)
        {
            CarP = car;
            Category = category;
        }

        public Car CarP { get; private set; }

        public string Category { get; private set; }

        public override string ToString()
        {
            return $"{Name},{Age},{Category},{CarP.Brand},{CarP.HPower}";
        }
    }
}
