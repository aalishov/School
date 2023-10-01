using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class CarParkingSpot : ParkingSpot
    {
        private const string SpotType = "car";

        public CarParkingSpot(int id, bool occupied, double price) : base(id, occupied, SpotType, price)
        {
        }
    }

