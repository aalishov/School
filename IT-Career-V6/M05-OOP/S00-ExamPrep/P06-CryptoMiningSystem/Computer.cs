using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_CryptoMiningSystem
{
    public class Computer
    {
        private int ram;

        public Computer(Processor processor, VideoCard videoCard, int ram)
        {
            Processor = processor;
            VideoCard = videoCard;
            Ram = ram;
        }

        public Processor Processor { get; set; }

        public VideoCard VideoCard { get; set; }

        public int Ram
        {
            get { return ram; }
            set
            {
                if (value <= 0 || value > 32)
                {
                    throw new ArgumentException("PC Ram cannot be less or equal to 0 and more than 32!");
                }
                ram = value;
            }
        }

        // TODO: Calculate: {Video card's mined money per hour} * {Processor's mined multiplier}
        public double MinedAmountPerHour { get { return VideoCard.MinedMoneyPerHour*Processor.MineMultiplier; } }
    }
}
