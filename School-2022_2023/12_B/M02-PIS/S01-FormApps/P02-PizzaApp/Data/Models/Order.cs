using System;
using System.Collections.Generic;
using System.Text;

namespace P02_PizzaApp.Data.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int PizzaId { get; set; }
        public virtual Pizza Pizza { get; set; }
        public int SizeId { get; set; }
        public virtual Size Size { get; set; }
        public int PaymantId { get; set; }
        public virtual Paymant Paymant { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;
        public virtual ICollection<Extra> Extras { get; set; }
    }
}
