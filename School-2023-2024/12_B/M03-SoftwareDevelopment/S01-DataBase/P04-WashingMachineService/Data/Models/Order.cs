using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingMachineService.Data.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int JobId { get; set; }
        public virtual Job Job { get; set; }
        public DateTime? IssueDate { get; set; }
        public bool Delivered { get; set; } = false;
        public virtual ICollection<OrderPart> OrdersParts { get; set; } = new List<OrderPart>();
    }
}
