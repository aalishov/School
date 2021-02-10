using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03_Parking
{
    public class Car
    {
        public string CarNumber { get; set; }

        public Car CarNext { get; set; }

        public override string ToString()
        {
            return $"Car: {this.CarNumber}";
        }
    }
}
