using Microsoft.AspNetCore.Identity;
using System;
using System.Collections;
using System.Collections.Generic;

namespace P05_Eventures.Data.Models
{
    public class Customer : IdentityUser
    {
        public DateTime RegisteredOn { get; private set; } = DateTime.Now;
        public virtual ICollection<Order> Orders { get; set; }
    }
}
