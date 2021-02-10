using System;
using System.Collections.Generic;
using System.Text;

namespace P04_VehicleLibrary
{
    public class Bus : Vehicle
    {
        const int InitalCapacity = 24;
        public Bus(string brand, string model, double fuelConsumption, double fuel) : base(brand, model, fuelConsumption, fuel)
        {
            this.PassengersCapacity = 24;
            this.CurrentPassengersCount = 0;
        }

        public int PassengersCapacity {  get; private set; }

        public int CurrentPassengersCount { get; set; }

        public void AddPassenger()
        {
            if (this.CurrentPassengersCount<this.PassengersCapacity)
            {
                CurrentPassengersCount++;
            }
        }

        public void RemovePassenger()
        {
            if (this.CurrentPassengersCount>0)
            {
                CurrentPassengersCount--;
            }
        }
    }
}
