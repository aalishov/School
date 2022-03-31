using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManager.Data.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public int Capacity { get; set; }
        public bool IsFree { get; set; }
        public double AdultPrice { get; set; }
        public double ChildPrice { get; set; }
    }
}
