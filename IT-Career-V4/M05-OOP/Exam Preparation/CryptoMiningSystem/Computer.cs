using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoMiningSystem
{
    public class Computer : IComputer
    {
        private int ram;

        public Computer(IProcessor processor, IVideoCard videoCard, int ram)
        {
            Processor = processor;
            VideoCard = videoCard;
            Ram = ram;
        }
        public IProcessor Processor { get; private set; }
        public IVideoCard VideoCard { get; private set; }
        public int Ram
        {
            get { return ram; }
            private set
            {
                if (value < 0 || value > 32)
                {
                    throw new ArgumentException("PC Ram cannot be less or equal to 0 and more than 32!");
                }
                ram = value;
            }
        }
        public double MinedAmountPerHour
        {
            get { return this.VideoCard.MinedMoneyPerHour * this.Processor.MineMultiplier; }
        }
    }
}
