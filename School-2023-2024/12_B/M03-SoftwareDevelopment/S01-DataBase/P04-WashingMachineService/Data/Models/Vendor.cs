using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingMachineService.Data.Models
{
    public class Vendor
    {
        public int VendorId { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }

    }
}
