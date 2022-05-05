using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManager.ViewModels.Users
{
    public class DetailsUserViewModel
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string NationalId { get; set; }
        public string Email { get; set; }
        public bool  IsActive { get; set; }
        public string DateOfIssue { get; set; }
        public string EndDate { get; set; }
    }
}
