using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P17_Success_1_3_24
{
    public class Moon : CelestialBody
    {
        public Moon(double weight, double diameter, Planet planet) : base(weight, diameter)
        {
            this.Planet = planet;
        }
        public Planet Planet { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}, Planet - {Planet}";
        }
    }
}
