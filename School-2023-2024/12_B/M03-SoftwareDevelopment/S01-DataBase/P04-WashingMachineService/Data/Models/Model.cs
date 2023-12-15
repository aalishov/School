using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingMachineService.Data.Models
{
    public class Model
    {
        
        public int ModelId { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public virtual ICollection<Job> Jobs { get; set; } = new List<Job>();
    }
}
