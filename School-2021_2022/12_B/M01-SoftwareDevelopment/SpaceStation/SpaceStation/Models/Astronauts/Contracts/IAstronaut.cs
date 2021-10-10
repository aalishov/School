namespace SpaceStation.Models.Astronauts.Contracts
{
    using Bags;
    using Bags.Contracts;

    public interface IAstronaut
    {
        public string Name { get; }

        public double Oxygen { get; }

        public bool CanBreath { get; }

        public IBag Bag { get; }

        public void Breath();
    }
}