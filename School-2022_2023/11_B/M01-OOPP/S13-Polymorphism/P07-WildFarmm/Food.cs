using System;
using System.Collections.Generic;
using System.Text;

public abstract class Food
{
    protected Food(int quantity)
    {
        Quantity = quantity;
    }

    public int Quantity { get; private set; }
}

