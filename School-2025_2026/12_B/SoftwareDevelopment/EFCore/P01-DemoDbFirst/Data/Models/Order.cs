using System;
using System.Collections.Generic;

namespace P01_DemoDbFirst.Data.Models;

public partial class Order
{
    public int Id { get; set; }

    public int ShoeId { get; set; }

    public int SizeId { get; set; }

    public int UserId { get; set; }

    public virtual Shoe Shoe { get; set; } = null!;

    public virtual Size Size { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
