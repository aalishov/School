public class Driller : Miner
{
    public Driller(string id, double coalOut, double energyRequirement) : base(id, coalOut*3, energyRequirement*2)
    {
    }
}

