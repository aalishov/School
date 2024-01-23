using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Table : Furniture
{
    public Table(string typeProduct, double productionPrice) : base(typeProduct, productionPrice)
    {
    }

    public override double PriceClient()
    {
        return ProductionPrice * 1.2;
    }

    public override string ToString()
    {
        return $"The table costs {PriceClient():f2} lv.";
    }
}

