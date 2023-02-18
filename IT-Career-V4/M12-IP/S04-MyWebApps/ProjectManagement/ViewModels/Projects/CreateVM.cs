using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.ViewModels.Projects
{
    public class CreateVM
    {
        public int OwnerId { get; set; }

        [DisplayName("Title: ")]
        [Required(ErrorMessage = "*This field is Required!")]
        public string Title { get; set; }

        [DisplayName("Description: ")]
        [Required(ErrorMessage = "*This field is Required!")]
        public string Description { get; set; }
    }
}
