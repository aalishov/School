using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07_Vehicle2
{
    public class Car : Vehicle
    {
        public Car(double fuelCapacity, double fuelQuantity, double fuelConsumption) : base(fuelCapacity, fuelQuantity, fuelConsumption + AppConstants.CarSummerFuel)
        {
        }
    }
}
