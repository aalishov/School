using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_ParkingSpot
{
    public class CarParkingSpot : ParkingSpot
    {
        public CarParkingSpot(int id, bool occupied,  double price) : base(id, occupied,"car", price)
        {
        }
        
    }
}
