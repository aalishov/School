namespace StudentSystem.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Student
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(10)]
        public string PhoneNumber { get; set; }

        public DateTime? BirthDay { get; set; }

        public DateTime RegisteredOn { get; } = DateTime.UtcNow;

        public virtual ICollection<StudentCourse> Courses { get; set; } = new HashSet<StudentCourse>();

        public virtual ICollection<Homework> Homeworks { get; set; } = new HashSet<Homework>();
    }
}
