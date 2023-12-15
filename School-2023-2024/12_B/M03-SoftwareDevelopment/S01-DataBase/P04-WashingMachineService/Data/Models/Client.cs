using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingMachineService.Data.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        [MaxLength(12)] 
        public string Phone { get; set; }

        public virtual ICollection<Job> Jobs { get; set; } = new List<Job>();

    }
}
