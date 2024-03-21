using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P17_Success_1_3_24
{
    public class Planet : CelestialBody
    {
        public Planet(double weight, double diameter, Star star) : base(weight, diameter)
        {
            Star = star;
        }
        public Star Star { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}, Star - {Star}";
        }
    }
}
