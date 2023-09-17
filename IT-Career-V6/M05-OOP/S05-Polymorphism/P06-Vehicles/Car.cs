using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_Vehicles
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption+AppConstants.CarSummerFuel)
        {
        }
    }
}
