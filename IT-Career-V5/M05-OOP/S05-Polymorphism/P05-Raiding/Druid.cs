namespace Raiding
{
    public class Druid : BaseHero
    {
        private const int DruidPower = 80;
        public Druid(string name) : base(name, DruidPower)
        {
        }
        public override string CastAbility()
        {
            return $"{this.GetType().Name} - {Name} healed for {Power}";
        }
    }
}
