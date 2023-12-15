using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WashingMachineService.Data.Models
{
    [PrimaryKey(nameof(JobId),nameof(PartId))]
    public class PartNeeded
    {
        public int JobId { get; set; }
        public virtual Job Job { get; set; }
        public int PartId { get; set; }
        public virtual Part Part { get; set; }
        public int Quantity { get; set; } = 1;
    }
}
