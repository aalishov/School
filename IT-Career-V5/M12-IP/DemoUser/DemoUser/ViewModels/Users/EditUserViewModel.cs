using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace DemoUser.ViewModels.Users
{
    public class EditUserViewModel
    {
        public string Id { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Display(Name = "Is admin")]
        public bool IsAdmin { get; set; }

        [Display(Name = "Is user")]
        public bool IsUser { get; set; }
    }
}
