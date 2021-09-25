namespace CryptoMiningSystem
{
  public  interface IComputer
    {
        public IProcessor Processor { get;  }
        public IVideoCard VideoCard { get; }
        public int Ram { get;  }
        public double MinedAmountPerHour { get; }
    }
}
