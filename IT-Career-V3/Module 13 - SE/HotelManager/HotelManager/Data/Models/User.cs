namespace HotelManager.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System;
    using System.ComponentModel.DataAnnotations;

    public class User : IdentityUser
    {
        public User()
        {
            EmailConfirmed = true;
        }

        [Required]
        [MaxLength(60)]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        [Required]
        [MaxLength(60)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(10)]
        public string NationalId { get; set; }
        public DateTime DateOfIssue { get; set; } = DateTime.UtcNow;
        public bool IsActive { get; set; } = true;
        public DateTime? ContractEndDate { get; set; }
    }
}
