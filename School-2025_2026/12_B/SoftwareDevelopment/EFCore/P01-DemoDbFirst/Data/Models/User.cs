using System;
using System.Collections.Generic;

namespace P01_DemoDbFirst.Data.Models;

public partial class User
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public string Email { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
