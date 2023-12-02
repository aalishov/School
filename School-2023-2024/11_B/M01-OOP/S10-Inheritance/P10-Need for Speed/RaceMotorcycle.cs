using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_Need_for_Speed
{
    public class RaceMotorcycle : Motorcycle
    {
        public RaceMotorcycle(double fuel, int horsePower) : base(fuel, horsePower)
        {
        }
        public override double FuelConsumption
        {
            get { return 8; }
        }
    }
}
