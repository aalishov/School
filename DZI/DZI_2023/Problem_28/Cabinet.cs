public class Cabinet : Furniture
{
    public Cabinet( double productionPrice, int numberOfHinges) : base(nameof(Cabinet).ToLower(), productionPrice)
    {
        this.NumberOfHinges = numberOfHinges;
    }

    public int NumberOfHinges { get; set; }

    public override double PriceClient()
    {
        return ProductionPrice * 1.15 + NumberOfHinges * 4.5;
    }

    public override string ToString()
    {
        return $"The cabinet costs {PriceClient():f2} lv.";
    }
}

