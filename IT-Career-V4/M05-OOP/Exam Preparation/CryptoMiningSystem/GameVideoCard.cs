using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoMiningSystem
{
    public class GameVideoCard : VideoCard
    {
        public GameVideoCard(string model, decimal price, int generation) : base(model, price, generation)
        {
        }
        public override int Generation
        {
            get { return base.Generation; }
            protected set
            {
                if (value > 9)
                {
                    throw new ArgumentException($"Game video card generation cannot be more than 9!");
                }
                base.Generation = value;
            }
        }
        public override int MinedMoneyPerHour
        {
            get
            {
                return base.MinedMoneyPerHour*2;
            }
        }
    }
}
