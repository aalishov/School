using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_ParkingSpot
{
    public class SubscriptionParkingSpot : ParkingSpot
    {
        private string registrationPlate;

        public SubscriptionParkingSpot(int id, bool occupied, double price, string registrationPlate) : base(id, occupied, "subscription", price)
        {
            RegistrationPlate = registrationPlate;
        }
        public string RegistrationPlate
        {
            get { return registrationPlate; }
            set
            {
                if (string.IsNullOrEmpty(registrationPlate))
                {
                    throw new ArgumentException("Registration plate can’t be null or empty!");
                }
                registrationPlate = value;
            }
        }
        public override string ToString()
        {
            return base.ToString()+$"\n>RegistrationPlate:{RegistrationPlate}"; 
        }
    }
}
