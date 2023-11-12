using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_CryptoMiningSystem
{
    public class GameVideoCard : VideoCard
    {
        public GameVideoCard(string model, double price, int generation, int ram) : base(model, price, generation, ram)
        {
        }

        public override int Generation
        {
            get { return base.Generation; }
            set
            {
                if (value > 9)
                {
                    throw new ArgumentException("Game video card generation cannot be more than 9!");
                }
                base.Generation = value;
            }
        }

        public override double MinedMoneyPerHour
        {
            get
            {
                return base.MinedMoneyPerHour * 2;
            }
        }
    }
}
