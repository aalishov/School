using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_OnlineStore.Data.Models
{
    [PrimaryKey(nameof(OrderId), nameof(ItemId))]
    public class OrderItem
    {
        public int OrderId { get; set; }

        public virtual Order Order { get; set; }

        public int ItemId { get; set; }

        public virtual Item Item { get; set; }
    }
}
