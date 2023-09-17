using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption + AppConstants.TruckSummerFuel)
        {
        }

        public override string Refuel(double fuelAmount)
        {
            return base.Refuel(fuelAmount * AppConstants.TruckReFuelReductionPercent);
        }
    }
}
