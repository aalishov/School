using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07_Vehicle2
{
    public class Truck : Vehicle
    {
        public Truck(double fuelCapacity, double fuelQuantity, double fuelConsumption) : base(fuelCapacity,fuelQuantity, fuelConsumption + AppConstants.TruckSummerFuel)
        {
        }

        public override string Refuel(double fuelAmount)
        {
            return base.Refuel(fuelAmount * AppConstants.TruckReFuelReductionPercent);
        }
    }
}
