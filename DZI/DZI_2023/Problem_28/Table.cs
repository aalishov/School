public class Table : Furniture
{
    public Table( double productionPrice) : base(nameof(Table).ToLower(), productionPrice)
    {
    }


    public override double PriceClient()
    {
        return this.ProductionPrice * 1.2;
    }

    public override string ToString()
    {
        return $"The table costs {PriceClient():f2} lv.";
    }
}

