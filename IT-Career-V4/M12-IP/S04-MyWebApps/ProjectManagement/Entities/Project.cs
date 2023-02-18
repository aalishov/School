using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Entities
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        public int OwnerId { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }

        [ForeignKey("OwnerId")]
        public User Owner { get; set; }
    }
}
