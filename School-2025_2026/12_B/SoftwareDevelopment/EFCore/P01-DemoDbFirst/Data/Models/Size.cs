using System;
using System.Collections.Generic;

namespace P01_DemoDbFirst.Data.Models;

public partial class Size
{
    public int Id { get; set; }

    public decimal Eu { get; set; }

    public decimal Us { get; set; }

    public decimal Uk { get; set; }

    public decimal Cm { get; set; }

    public decimal In { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<Shoe> Shoes { get; set; } = new List<Shoe>();
}
