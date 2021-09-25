namespace CryptoMiningSystem
{
  public  interface IComponent
    {
        public string Model { get;  }
        public decimal Price { get;  }
        public int Generation { get; }
        public int LifeWorkingHours { get;  }
    }
}
