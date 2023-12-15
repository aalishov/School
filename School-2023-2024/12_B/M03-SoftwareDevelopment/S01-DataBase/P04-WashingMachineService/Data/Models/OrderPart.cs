using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingMachineService.Data.Models
{
    [PrimaryKey(nameof(OrderId),nameof(PartId))]
    public class OrderPart
    {
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
        public int PartId { get; set; }
        public virtual Part Part { get; set; }
        public int Quantity { get; set; }
    }
    
}
