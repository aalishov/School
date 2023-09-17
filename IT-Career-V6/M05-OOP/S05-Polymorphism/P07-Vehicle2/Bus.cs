using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07_Vehicle2
{
    public class Bus : Vehicle
    {
        public Bus(double fuelCapacity, double fuelQuantity, double fuelConsumption) : base(fuelCapacity, fuelQuantity, fuelConsumption)
        {
        }

        public bool HasPassengers { get; set; }

        public override double FuelConsumption
        {
            get
            {
                if (HasPassengers)
                {
                    return base.FuelConsumption + AppConstants.BusSummerFuel;
                }
                return base.FuelConsumption;
            }
            set => base.FuelConsumption = value;
        }
    }
}
