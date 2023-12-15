using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingMachineService.Data.Models
{
    public class Part
    {
        public int PartId { get; set; }
        [MaxLength(50)]
        public string SerialNumber { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int VendorId { get; set; }
        public virtual Vendor Vendor { get; set; }
        public int StockQty { get; set; } = 0;
        public virtual ICollection<OrderPart> OrdersParts { get; set; } = new List<OrderPart>();
        public virtual ICollection<PartNeeded> PartsNeeded { get; set; } = new List<PartNeeded>();
    }
}
