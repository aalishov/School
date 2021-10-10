public class Hewer : Miner
{
    public Hewer(string id, double coalOut, double energyRequirement,int enduranceFactor) : base(id, coalOut, energyRequirement/enduranceFactor)
    {
        this.EnduranceFactor = enduranceFactor;
    }

    public int EnduranceFactor { get; set; }
}
