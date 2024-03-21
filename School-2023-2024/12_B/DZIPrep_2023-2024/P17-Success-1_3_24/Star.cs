using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P17_Success_1_3_24
{
    public class Star : CelestialBody
    {
        public Star(double weight, double diameter, string type) : base(weight, diameter)
        {
            this.Type = type;
        }
        public string Type { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}, Type - {Type}";
        }
    }
}
