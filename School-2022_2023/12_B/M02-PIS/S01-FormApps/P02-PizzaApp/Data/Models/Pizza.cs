using System;
using System.Collections.Generic;
using System.Text;

namespace P02_PizzaApp.Data.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
    }
}
