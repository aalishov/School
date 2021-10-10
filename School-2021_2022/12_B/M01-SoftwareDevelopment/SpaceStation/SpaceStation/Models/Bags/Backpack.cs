using SpaceStation.Models.Bags.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStation.Models.Bags
{
    public class Backpack : IBag
    {
        public ICollection<string> Items { get; set; }

        public Backpack()
        {
            this.Items = new List<string>();
        }
    }
}
