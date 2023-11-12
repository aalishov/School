using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_CryptoMiningSystem
{
    public class MineVideoCard : VideoCard
    {
        public MineVideoCard(string model, double price, int generation, int ram) : base(model, price, generation, ram)
        {
            LifeWorkingHours *= 2;
        }

        public override int Generation
        {
            get { return base.Generation; }
            set
            {
                if (value > 6)
                {
                    throw new ArgumentException("Mine video card generation cannot be more than 6!");
                }
                base.Generation = value;
            }
        }

        public override double MinedMoneyPerHour
        {
            get
            {
                return base.MinedMoneyPerHour*8;
            }
        }

    }
}
