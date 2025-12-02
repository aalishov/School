using System;
using System.Collections.Generic;

namespace P01_DemoDbFirst.Data.Models;

public partial class Brand
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Shoe> Shoes { get; set; } = new List<Shoe>();
}
