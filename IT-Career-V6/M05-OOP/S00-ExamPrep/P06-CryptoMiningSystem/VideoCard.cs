using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace P06_CryptoMiningSystem
{
    public class VideoCard : Component
    {
        private int ram;

        public VideoCard(string model, double price, int generation, int ram) : base(model, price, generation)
        {
            Ram = ram;
            LifeWorkingHours = Ram * Generation * 10;
        }

        public int Ram
        {
            get { return ram; }
            set
            {
                if (value <= 0 || value > 32)
                {
                    throw new ArgumentException($"{GetType().Name} ram cannot less or equal to 0 and more than 32!");
                }
                ram = value;
            }
        }

        public virtual double MinedMoneyPerHour
        {
            get
            {
                return Ram * Generation / 10.0;
            }
        }

    }
}
