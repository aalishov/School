using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Vehicles
{
    public class Semi : Vehicle
    {
        private const int semiCapacity = 10;
        public Semi() : base(semiCapacity)
        {
        }
    }
}
