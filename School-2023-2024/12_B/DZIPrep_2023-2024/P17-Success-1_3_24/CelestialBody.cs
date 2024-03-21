using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P17_Success_1_3_24
{
    public abstract class CelestialBody
    {
        protected CelestialBody(double weight, double diameter)
        {
            Weight = weight;
            Diameter = diameter;
        }

        public double Weight { get; set; }

        public double Diameter { get; set; }

        public override string ToString()
        {
            return $"Info {this.GetType().Name}: Weight - {Weight}, Diameter - {Diameter}";
        }
    }
}
