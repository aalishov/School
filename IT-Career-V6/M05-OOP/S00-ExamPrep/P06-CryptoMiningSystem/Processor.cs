using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_CryptoMiningSystem
{
    public abstract class Processor : Component
    {
        protected Processor(string model, double price, int generation, int mineMultiplier) : base(model, price, generation)
        {
            MineMultiplier= mineMultiplier;
            LifeWorkingHours= generation*100;
        }

        public int MineMultiplier { get; set; }

        public override int Generation
        {
            get
            {
                return base.Generation;
            }

            set
            {
                if (value > 9)
                {
                    throw new ArgumentException($"{GetType().Name} generation cannot be more than 9!");
                }
                base.Generation = value;
            }
        }
    }
}
