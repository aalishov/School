using System;
using System.Collections.Generic;

namespace P01_DemoDbFirst.Data.Models;

public partial class Shoe
{
    public int Id { get; set; }

    public string Model { get; set; } = null!;

    public decimal Price { get; set; }

    public int BrandId { get; set; }

    public virtual Brand Brand { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<Size> Sizes { get; set; } = new List<Size>();
}
