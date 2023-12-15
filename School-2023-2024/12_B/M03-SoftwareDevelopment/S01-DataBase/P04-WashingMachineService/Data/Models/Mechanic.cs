using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingMachineService.Data.Models
{
    public class Mechanic
    {
        public int MechanicId { get; set; }
        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        [MaxLength(255)]
        public string Address { get; set; }

        public virtual ICollection<Job> Jobs { get; set; } = new List<Job>();

    }
}
