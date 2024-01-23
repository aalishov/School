using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Cabinet : Furniture
{
    public Cabinet(string typeProduct, double productionPrice, int numberOfHinges) : base(typeProduct, productionPrice)
    {
        NumberOfHinges = numberOfHinges;
    }

    public int NumberOfHinges { get; set; }

    public override double PriceClient()
    {
        return ProductionPrice * 1.15 + 4.5 * NumberOfHinges;
    }

    public override string ToString()
    {
        return $"The cabinet costs {PriceClient():f2} lv.";
    }
}

