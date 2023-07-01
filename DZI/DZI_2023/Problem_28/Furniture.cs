using System;

public abstract class Furniture
{
    private string typeProduct;
    private double productionPrice;

    protected Furniture(string typeProduct, double productionPrice)
    {
        TypeProduct = typeProduct;
        ProductionPrice = productionPrice;
    }

    public string TypeProduct
    {
        get { return typeProduct; }
        set
        {
            if (string.IsNullOrWhiteSpace(value)) 
            {
                throw new ArgumentException(nameof(TypeProduct));
            }
            typeProduct = value;
        }
    }

    public double ProductionPrice
    {
        get { return productionPrice; }
        set
        {
            if (value<=0)
            {
                throw new ArgumentException(nameof(ProductionPrice));
            }
            productionPrice = value;
        }
    }

    public abstract double PriceClient();
}

